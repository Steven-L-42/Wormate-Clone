using System.Linq;
using UnityEngine;

public class EnemyProcess : MonoBehaviour
{

    [SerializeField] float slowSpeed = 2.5f;
    [SerializeField] float fastSpeed = 3.5f;
    float speed;
    [SerializeField] float rotateSpeed = 360f;
    public Transform Self;
    public Rigidbody rigidbody;
    public bool _Enemy, _Player = true;
    public bool _Food = true;
    bool found = false;

    Transform GetClosestTarget(Transform[] enemies)
    {
        Transform bestTarget = null;
        float closestDistanceSqr = Mathf.Infinity;
        Vector3 currentPosition = transform.position;
        foreach (Transform potentialTarget in enemies)
        {
            Vector3 directionToTarget = potentialTarget.position - currentPosition;
            float dSqrToTarget = directionToTarget.sqrMagnitude;
            if (dSqrToTarget < closestDistanceSqr)
            {
                closestDistanceSqr = dSqrToTarget;
                bestTarget = potentialTarget;
            }
        }
        return bestTarget;
    }

    private void Start()
    {
        speed = slowSpeed;
    }
    private void Update()
    {
        try
        {
            Transform[] TransformFromFood;
            Transform[] TransformFromEnemy;
            Transform[] TransformFromPlayer;
            Transform NearestTarget = Self;
            Transform NearestFood = null;
            Transform NearestEnemy = null;
            Transform NearestPlayer = null;
            float distFood = 0;
            float distEnemy = 0;
            float distPlayer = 0;
            bool player = false;
            bool enemy = false;
            bool food = false;

            // FOOD
            if (GameObject.FindGameObjectsWithTag("Food").Count() >= 1)
            {
                GameObject[] GameObjectFromFood = GameObject.FindGameObjectsWithTag("Food");
                TransformFromFood = new Transform[GameObjectFromFood.Length];
                for (int i = 0; i < GameObjectFromFood.Length; i++)
                {
                    TransformFromFood[i] = GameObjectFromFood[i].transform;
                }
                NearestFood = GetClosestTarget(TransformFromFood);
                food = true;
            }
            // ENEMY
            if(GameObject.FindGameObjectsWithTag("Enemy").Count() >= 2)
            {
                this.gameObject.tag = "NotEnemy";
                GameObject[] GameObjectFromEnemy = GameObject.FindGameObjectsWithTag("Enemy");
                this.gameObject.tag = "Enemy";
                TransformFromEnemy = new Transform[GameObjectFromEnemy.Length];
                for (int i = 0; i < GameObjectFromEnemy.Length; i++)
                {
                    TransformFromEnemy[i] = GameObjectFromEnemy[i].transform;
                }
                NearestEnemy = GetClosestTarget(TransformFromEnemy);
                enemy = true;
            }

            if (GameObject.FindGameObjectsWithTag("Player").Count() >= 1)
            {
                // PLAYER
                GameObject[] GameObjectFromPlayer = GameObject.FindGameObjectsWithTag("Player");
                TransformFromPlayer = new Transform[GameObjectFromPlayer.Length];
                for (int i = 0; i < GameObjectFromPlayer.Length; i++)
                {
                    TransformFromPlayer[i] = GameObjectFromPlayer[i].transform;
                }
                NearestPlayer = GetClosestTarget(TransformFromPlayer);
                player = true;
            }
            if (food)
                distFood = Vector3.Distance(transform.position, NearestFood.position);
            else
                NearestFood = null;
            if (enemy)
                distEnemy = Vector3.Distance(transform.position, NearestEnemy.position);
            else
                NearestEnemy = null;
            if (player)
                distPlayer = Vector3.Distance(transform.position, NearestPlayer.position);
            else
                NearestPlayer = null;

            if (distFood < distEnemy && NearestFood != null || NearestEnemy == null)
            {
                NearestTarget = NearestFood;
                found = true;
            }
            else
                if (distFood > distEnemy && NearestEnemy != null)
            {
                NearestTarget = NearestEnemy;
                found = true;
            }
            else
                if (distFood > distPlayer && NearestPlayer != null)
            {
                NearestTarget = NearestPlayer;
                found = true;
            }
            else
            {
                found = false;
            }

            if (found)
            {
                switch (Random.Range(0,10))
                {
                    case 2:
                        speed = fastSpeed;
                        break;
                    default:
                        speed = slowSpeed;
                        break;
                }
                Vector2 direction = new Vector2(NearestTarget.transform.position.x - transform.position.x, NearestTarget.position.y - transform.position.y);
                rigidbody.velocity = rigidbody.transform.right * speed;
                float angle = Mathf.Atan2(NearestTarget.position.y - Self.position.y, NearestTarget.position.x - Self.position.x) * Mathf.Rad2Deg;
                Quaternion qTo = Quaternion.Euler(new Vector3(0, 0, angle));
                rigidbody.transform.rotation = Quaternion.RotateTowards(rigidbody.transform.rotation, qTo, rotateSpeed * Time.deltaTime);
               

            }
        }
        catch (System.Exception ex)
        {
            print("EnemyProcess: " + ex.ToString());
        }
    }
}
