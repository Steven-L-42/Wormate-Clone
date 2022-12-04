using Mirror;
using UnityEngine;

public class PBodyKillEHead : MonoBehaviour
{
    public GameObject[] Food;
    Transform transtemp;
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "EHead")
        {
            if (other.transform.parent.gameObject.scene.IsValid())
            {
               
                transtemp = other.transform.parent.gameObject.transform;
                Destroy(other.transform.parent.gameObject);
                NetworkServer.Destroy(other.transform.parent.gameObject);
                GameObject temp1, temp2, temp3;
                foreach (Transform child in transtemp)
                {
                    temp1 = Instantiate(Food[Random.Range(0, 41)], new Vector3(child.position.x- 0.1f, child.position.y - 0.1f, 0), Quaternion.identity);
                    NetworkServer.Spawn(temp1);
                    temp2 = Instantiate(Food[Random.Range(0, 41)], new Vector3(child.position.x, child.position.y, 0), Quaternion.identity);
                    NetworkServer.Spawn(temp2);
                    temp3 = Instantiate(Food[Random.Range(0, 41)], new Vector3(child.position.x + 0.1f, child.position.y + 0.1f, 0), Quaternion.identity);
                    NetworkServer.Spawn(temp3);
                }                   
            }        
        }
    }
}

