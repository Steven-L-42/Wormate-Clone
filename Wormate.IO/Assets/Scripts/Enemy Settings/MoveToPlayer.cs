using UnityEngine;

public class MoveToPlayer : MonoBehaviour
{

    private Transform target;
    public float within_range;
    public float speed;
    private void Start()
    {
        target = GameObject.FindWithTag("Player").transform;
    }
    public void Update()
    {

       
        //get the distance between the player and enemy (this object)
        float dist = Vector3.Distance(target.position, transform.position);
        //check if it is within the range you set
        if (dist <= within_range)
        {
            //move to target(player) 
            transform.position = Vector3.MoveTowards(transform.position, target.transform.position, speed);
        }
        //else, if it is not in rage, it will not follow player
    }
}
