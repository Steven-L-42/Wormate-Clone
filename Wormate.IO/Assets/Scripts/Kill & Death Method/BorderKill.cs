using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BorderKill : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Border")
        {
            Destroy(transform.gameObject);
        }
       
    }
    
}
