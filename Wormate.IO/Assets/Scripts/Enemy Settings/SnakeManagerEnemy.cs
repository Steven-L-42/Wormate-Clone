using System.Collections.Generic;
using UnityEngine;

public class SnakeManagerEnemy : MonoBehaviour
{
    [SerializeField] private float distanceBetween = 0.4f;

    [SerializeField] public List<GameObject> bodyParts = new List<GameObject>();
    private List<GameObject> snakeBody = new List<GameObject>();
    private GrowEnemy grow;
    public int startSize = 10;
    private float countUp = 0;
    private bool _GameStarted;

    private void Start()
    {
        grow = GetComponent<GrowEnemy>();
    }

    private void FixedUpdate()
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

    private void ManageSnakeBody()
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

    private void SnakeMovement()
    {
        if (snakeBody.Count > 1)
        {
            for (int i = 1; i < snakeBody.Count; i++)
            {
                MarkerManagerEnemy markM = snakeBody[i - 1].GetComponent<MarkerManagerEnemy>();
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
            if (!tempHead.GetComponent<MarkerManagerEnemy>())
                tempHead.AddComponent<MarkerManagerEnemy>();

            if (!tempHead.GetComponent<SphereCollider>())
            {
                tempHead.AddComponent<SphereCollider>().isTrigger = true;
                tempHead.GetComponent<SphereCollider>().radius = 0.4f;
            }
            tempHead.tag = "EHead";

            tempHead.GetComponent<Renderer>().sortingLayerID = SortingLayer.NameToID("EHead");
            tempHead.GetComponent<Renderer>().sortingOrder = -snakeBody.Count;
            tempHead.transform.parent = transform;
            snakeBody.Add(tempHead);
            bodyParts.RemoveAt(0);
        }
        MarkerManagerEnemy markM = snakeBody[snakeBody.Count - 1].GetComponent<MarkerManagerEnemy>();
        if (countUp == 0)
        {
            markM.ClearMarkerList();
        }
        countUp += Time.deltaTime;
        if (countUp >= distanceBetween)
        {
            GameObject tempBody = Instantiate(bodyParts[0], markM.markerList[0].position, markM.markerList[0].rotation, transform);
            if (!tempBody.GetComponent<MarkerManagerEnemy>())
                tempBody.AddComponent<MarkerManagerEnemy>();

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

            tempBody.tag = "EBody";

            tempBody.GetComponent<Renderer>().sortingLayerID = SortingLayer.NameToID("EBody");
            tempBody.GetComponent<Renderer>().sortingOrder = -snakeBody.Count;
            tempBody.transform.parent = transform;
            snakeBody.Add(tempBody);
            bodyParts.RemoveAt(0);

            tempBody.GetComponent<MarkerManagerEnemy>().ClearMarkerList();
            countUp = 0;
        }
    }

    public void AddBodyParts(GameObject obj)
    {
        bodyParts.Add(obj);
    }
}