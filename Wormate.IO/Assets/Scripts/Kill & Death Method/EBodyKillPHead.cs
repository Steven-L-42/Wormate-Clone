using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EBodyKillPHead : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "PHead")
        {
            if (other.transform.parent.gameObject.scene.IsValid())
            {
                Destroy(other.transform.parent.gameObject);

            }
        }
    }
}
