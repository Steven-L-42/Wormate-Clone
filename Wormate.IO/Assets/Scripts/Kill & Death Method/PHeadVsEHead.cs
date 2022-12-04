using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PHeadVsEHead : MonoBehaviour
{
  
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "EHead")
        {
            if (other.transform.parent.gameObject.transform.localScale.x < transform.parent.gameObject.transform.localScale.x)
            {
                if (other.transform.parent.gameObject.scene.IsValid())
                {
                    Destroy(other.transform.parent.gameObject);
               
                }
            }
            else if (other.transform.parent.gameObject.transform.localScale.x > transform.parent.gameObject.transform.localScale.x)
            {
                if (transform.parent.gameObject.scene.IsValid())
                {
                    Destroy(transform.parent.gameObject);
                 
                }
            }
        }
        else if (other.gameObject.tag == "PHead")
        {
            if (other.transform.parent.gameObject.transform.localScale.x < transform.parent.gameObject.transform.localScale.x)
            {
                if (other.transform.parent.gameObject.scene.IsValid())
                {
                    Destroy(other.transform.parent.gameObject);
                
                }
            }
            else if (other.transform.parent.gameObject.transform.localScale.x > transform.parent.gameObject.transform.localScale.x)
            {
                if (transform.parent.gameObject.scene.IsValid())
                {
                    Destroy(transform.parent.gameObject);
             

                }
            }

        }
    }
}