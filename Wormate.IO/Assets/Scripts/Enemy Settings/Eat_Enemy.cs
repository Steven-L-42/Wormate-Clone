using System.Net.NetworkInformation;
using UnityEngine;

public class Eat_Enemy : MonoBehaviour
{
    public GrowEnemy growEnemy;
    public string food, bang, ring;
    public float Increase;
  
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == bang || other.gameObject.tag == ring)
            Destroy(other.gameObject);
        if (other.gameObject.tag == food)
        {
            Destroy(other.gameObject);
            transform.localScale += new Vector3(Increase, Increase, Increase);
            growEnemy.AddBodyParts(1);
        }

    }
}
