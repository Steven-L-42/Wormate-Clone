using Mirror;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;
public class SnakeManager : NetworkBehaviour
{
    [SyncVar]
    [SerializeField] float distanceBetween = 0.4f;
    [SyncVar]
    [SerializeField] public float slowSpeed = 2.5f;
    [SyncVar]
    [SerializeField] public float fastSpeed = 3.5f;
    [SyncVar]
    [SerializeField] public float rotateSpeed = 360f;
    [SyncVar]
    [SerializeField] public List<GameObject> bodyParts = new List<GameObject>();
    [SyncVar]
    public List<GameObject> snakeBody = new List<GameObject>();
 
    public Rigidbody rigidbody;
    [SyncVar]
    Eat eat;
    [SyncVar]
    public MoveWindow move;
    [SyncVar]
    GrowPlayer grow;
    [SyncVar]
    float countUp = 0;
    [SyncVar]
    bool fastMode;
    [SyncVar]
    bool _GameStarted;
    [SyncVar]
    float speed;
    [SyncVar]
    public int startSize = 10;

    static int numberOfPlayers = 0;
    public Vector3[] startPositions;

    public override void OnStartClient()
    {
        //if(!isLocalPlayer)
        //{
        //    GetComponent<SnakeManager>.enabled = false;
        //}
        move = Camera.main.GetComponent<MoveWindow>();
        eat = this.GetComponent<Eat>();
        grow = this.GetComponent<GrowPlayer>();
        InvokeRepeating("DecreaseScore", 0, 1f);  //1s delay, repeat every 1s 
    }
    private void Awake()
    {
        if(numberOfPlayers > 3)
        {
            Destroy(gameObject);
            return;
        }
        transform.position = startPositions[numberOfPlayers];
        numberOfPlayers++;
    }
    void DecreaseScore()
    {
        if (fastMode)
        {
            eat.FastModeSetScore();
            //GameObject.Destroy(snakeBody[snakeBody.Count - 1]);
            //snakeBody.RemoveAt(snakeBody.Count - 1);
        }
    }

    void FixedUpdate()
    {
        if (!_GameStarted)
        {
          
            grow.AddBodyParts(startSize);
            _GameStarted = true;
        }
        else
        {
            ManageSnakeBody();
            SnakeMovement();
        }     
      
    }
    void Update()
    {

        if (eat.Score >= 3 && snakeBody.Count > 8)
        {
            if (Input.GetMouseButtonDown(0))
            {
                fastMode = true;
                speed = fastSpeed;
            }
            else
            if (Input.GetMouseButtonUp(0))
            {
                fastMode = false;
                speed = slowSpeed;
            }
        }
        else
        {
            fastMode = false;
            speed = slowSpeed;
        }
    }

    void ManageSnakeBody()
    {
        if (bodyParts.Count > 0)
        {
            CreateBodyParts();
        }

        for (int i = 0; i < snakeBody.Count; i++)
        {
            if (snakeBody[i].transform.position == null)
            {
                snakeBody.RemoveAt(i);
                i = i - 1;
            }
            if (snakeBody.Count == 0)
                Destroy(this);
        }
    }
   
    void SnakeMovement()
    {
        rigidbody.velocity = rigidbody.transform.right * speed;

        Vector3 Target = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        Target.z = -1;

        float angle = Mathf.Atan2(Target.y - snakeBody[0].transform.position.y, Target.x - snakeBody[0].transform.position.x) * Mathf.Rad2Deg;
        Quaternion qTo = Quaternion.Euler(new Vector3(0, 0, angle));
        rigidbody.transform.rotation = Quaternion.RotateTowards(rigidbody.transform.rotation, qTo, rotateSpeed * Time.fixedDeltaTime);
        move.MoveMainCamera(snakeBody[0].transform);
      
        if (snakeBody.Count > 1)
        {
            for (int i = 1; i < snakeBody.Count; i++)
            {
                MarkerManager markM = snakeBody[i - 1].GetComponent<MarkerManager>();
                snakeBody[i].transform.SetPositionAndRotation(markM.markerList[0].position, markM.markerList[0].rotation);
                markM.markerList.RemoveAt(0);
            }
        }
    }
    private void CreateBodyParts()
    {
        if (snakeBody.Count == 0)
        {

            GameObject tempHead = Instantiate(bodyParts[0], transform.position, transform.rotation, transform);
           
            if (!tempHead.GetComponent<MarkerManager>())
                tempHead.AddComponent<MarkerManager>();
            if (!tempHead.GetComponent<NetworkIdentity>())
                tempHead.AddComponent<NetworkIdentity>();

            if (!tempHead.GetComponent<SphereCollider>())
            {
                tempHead.AddComponent<SphereCollider>().isTrigger = true;
                tempHead.GetComponent<SphereCollider>().radius = 0.4f;
            }
            tempHead.tag = "PHead";

            tempHead.GetComponent<Renderer>().sortingLayerID = SortingLayer.NameToID("PHead");
            tempHead.GetComponent<Renderer>().sortingOrder = -snakeBody.Count;
            tempHead.transform.parent = transform;
            snakeBody.Add(tempHead);
            NetworkServer.Spawn(tempHead);
            bodyParts.RemoveAt(0);



        }
        MarkerManager markM = snakeBody[snakeBody.Count - 1].GetComponent<MarkerManager>();
        if (countUp == 0)
        {
            markM.ClearMarkerList();
        }
        countUp += Time.deltaTime;
        if (countUp >= distanceBetween)
        {
            GameObject tempBody = Instantiate(bodyParts[0], markM.markerList[0].position, markM.markerList[0].rotation, transform);
            if (!tempBody.GetComponent<MarkerManager>())
                tempBody.AddComponent<MarkerManager>();
            if (!tempBody.GetComponent<NetworkIdentity>())
                tempBody.AddComponent<NetworkIdentity>();

            if (!tempBody.GetComponent<Rigidbody>())
                {
                    tempBody.AddComponent<Rigidbody>().isKinematic = false;
                    tempBody.GetComponent<Rigidbody>().useGravity = false;
                }
                if (!tempBody.GetComponent<SphereCollider>())
                {
                    tempBody.AddComponent<SphereCollider>().isTrigger = true;
                    tempBody.GetComponent<SphereCollider>().radius = 0.4f;
                }
            
            tempBody.tag = "PBody";
         
            tempBody.GetComponent<Renderer>().sortingLayerID = SortingLayer.NameToID("PBody");
            tempBody.GetComponent<Renderer>().sortingOrder = -snakeBody.Count;
            tempBody.transform.parent = transform;
            snakeBody.Add(tempBody);
            NetworkServer.Spawn(tempBody);
            bodyParts.RemoveAt(0);

            tempBody.GetComponent<MarkerManager>().ClearMarkerList();
            countUp = 0;

        }

    }

    public void AddBodyParts(GameObject obj)
    {
        bodyParts.Add(obj);
    }
}
