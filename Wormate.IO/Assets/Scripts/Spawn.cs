using Mirror;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.Networking;

public class Spawn : NetworkBehaviour
{

    List<GameObject> tempRings = new List<GameObject>();
    List<GameObject> tempPowerups = new List<GameObject>();
    List<GameObject> tempBangs = new List<GameObject>();
    List<GameObject> tempFood = new List<GameObject>();
    List<GameObject> tempPumpkin = new List<GameObject>();

    public List<GameObject> spawnables = new List<GameObject>();
    public GameObject Enemy;
    public GameObject[] bangs;
    public GameObject[] rings;
    public GameObject[] sweets;
    public GameObject[] pumpkins;
    public GameObject[] powerups;


    public BoxCollider2D Playground;

    [Header("Spawn /s Food")]
    public float spawnSpeedF = 1;
    [Header("Max. Exist Food")]
    public int maxSpawnsF = 100;
    [Header("----------------")]
    [Header("Spawn /s Enemy")]
    public float spawnSpeedE = 5;
    [Header("Max. Exist Enemy")]
    public int maxSpawnsE = 5;

    [Header("----------------")]
    [Header("Spawn /s Powerups")]
    public float spawnSpeedP = 5;
    [Header("Max. Exist Powerups")]
    public int maxSpawnsP = 10;

    Transform player;
    float x;
    float y;
    private int pumpkinCount;
    bool _ServerStopped = false;
    public override void OnStartServer()
    {
        _ServerStopped = false;
        //Playground = GetComponent<BoxCollider2D>();
        //player = GameObject.FindWithTag("Player").transform;
        InvokeRepeating("GeneratePowerup", 0, spawnSpeedP);
        InvokeRepeating("GenerateFood", 0, spawnSpeedF);
        InvokeRepeating("GenerateEnemy", 0, spawnSpeedE);
        RandomizePosition();
    }
    public override void OnStopServer()
    {
        _ServerStopped = true;
    }
        private void RandomizePosition()
    {
        Bounds bounds = Playground.bounds;
        x = Random.Range(bounds.min.x, bounds.max.x);
        y = Random.Range(bounds.min.y, bounds.max.y);
    }

    void GenerateFood()
    {
        if (!_ServerStopped)
        {

        if (GameObject.FindGameObjectsWithTag("Food").Count() < maxSpawnsF)
        {
          
            RandomizePosition();
            tempBangs.Add(Instantiate(bangs[Random.Range(0, 3)], new Vector3(x, y, 0.0f), Quaternion.identity));
            tempFood.Add(Instantiate(sweets[Random.Range(0, 41)], new Vector3(x, y, 0.0f), Quaternion.identity));
            Destroy(tempBangs.Last(), 90);
            Destroy(tempFood.Last(), 90);
            NetworkServer.Spawn(tempBangs.Last());
            NetworkServer.Spawn(tempFood.Last());
            float temp1 = 0, temp2 = 0;
            int RandomGridSize = Random.Range(0, 10);
            for (int i = 0; i <= RandomGridSize; i++)
            {
                switch (i)
                {
                    case 0:
                        temp1 = Random.Range(1, 4); temp2 = Random.Range(1, 4);
                        break;
                    case 1:
                        temp1 = Random.Range(2, 5); temp2 = Random.Range(2, 5);
                        break;
                    case 2:
                        temp1 = Random.Range(3, 6); temp2 = Random.Range(3, 6);
                        break;
                    case 3:
                        temp1 = Random.Range(4, 7); temp2 = Random.Range(4, 7);
                        break;
                    case 4:
                        temp1 = Random.Range(5, 8); temp2 = Random.Range(5, 8);
                        break;
                    case 5:
                        temp1 = Random.Range(6, 9); temp2 = Random.Range(6, 9);
                        break;
                    case 6:
                        temp1 = Random.Range(7, 10); temp2 = Random.Range(7, 10);
                        break;
                    case 7:
                        temp1 = Random.Range(8, 11); temp2 = Random.Range(8, 11);
                        break;
                    case 8:
                        temp1 = Random.Range(9, 12); temp2 = Random.Range(9, 12);
                        break;
                    case 9:
                        temp1 = Random.Range(10, 13); temp2 = Random.Range(10, 13);
                        break;
                }
                switch (Random.Range(0, 9))
                {
                    case 0:
                        tempBangs.Add(Instantiate(bangs[Random.Range(0, 3)], new Vector3(x, y - temp1, 0.0f), Quaternion.identity));
                        tempFood.Add(Instantiate(sweets[Random.Range(0, 41)], new Vector3(x, y - temp1, 0.0f), Quaternion.identity)); 

                        Destroy(tempBangs.Last(), 60);
                        Destroy(tempFood.Last(), 60);
                        NetworkServer.Spawn(tempBangs.Last());
                        NetworkServer.Spawn(tempFood.Last());
                        break;
                    case 1:
                        tempBangs.Add(Instantiate(bangs[Random.Range(0, 3)], new Vector3(x, y + temp1, 0.0f), Quaternion.identity));
                        tempFood.Add(Instantiate(sweets[Random.Range(0, 41)], new Vector3(x, y + temp1, 0.0f), Quaternion.identity));
                        Destroy(tempBangs.Last(), 70);
                        Destroy(tempFood.Last(), 70);
                        NetworkServer.Spawn(tempBangs.Last());
                        NetworkServer.Spawn(tempFood.Last());

                        break;
                    case 2:
                        tempBangs.Add(Instantiate(bangs[Random.Range(0, 3)], new Vector3(x - temp1, y, 0.0f), Quaternion.identity));
                        tempFood.Add(Instantiate(sweets[Random.Range(0, 41)], new Vector3(x - temp1, y, 0.0f), Quaternion.identity));

                        Destroy(tempBangs.Last(), 80);
                        Destroy(tempFood.Last(), 80);
                        NetworkServer.Spawn(tempBangs.Last());
                        NetworkServer.Spawn(tempFood.Last());

                        break;
                    case 3:
                        tempBangs.Add(Instantiate(bangs[Random.Range(0, 3)], new Vector3(x + temp1, y, 0.0f), Quaternion.identity));
                        tempFood.Add(Instantiate(sweets[Random.Range(0, 41)], new Vector3(x + temp1, y, 0.0f), Quaternion.identity));

                        Destroy(tempBangs.Last(), 90);
                        Destroy(tempFood.Last(), 90);
                        NetworkServer.Spawn(tempBangs.Last());
                        NetworkServer.Spawn(tempFood.Last());

                        break;
                    case 4:
                        tempBangs.Add(Instantiate(bangs[Random.Range(0, 3)], new Vector3(x + temp1, y + temp2, 0.0f), Quaternion.identity));
                        tempFood.Add(Instantiate(sweets[Random.Range(0, 41)], new Vector3(x + temp1, y + temp2, 0.0f), Quaternion.identity));

                        Destroy(tempBangs.Last(), 50);
                        Destroy(tempFood.Last(), 50);
                        NetworkServer.Spawn(tempBangs.Last());
                        NetworkServer.Spawn(tempFood.Last());

                        break;
                    case 5:
                        tempBangs.Add(Instantiate(bangs[Random.Range(0, 3)], new Vector3(x - temp1, y - temp2, 0.0f), Quaternion.identity));
                        tempFood.Add(Instantiate(sweets[Random.Range(0, 41)], new Vector3(x - temp1, y - temp2, 0.0f), Quaternion.identity));

                        Destroy(tempBangs.Last(), 40);
                        Destroy(tempFood.Last(), 40);
                        NetworkServer.Spawn(tempBangs.Last());
                        NetworkServer.Spawn(tempFood.Last());

                        break;
                    case 6:
                        tempBangs.Add(Instantiate(bangs[Random.Range(0, 3)], new Vector3(x + temp1, y - temp2, 0.0f), Quaternion.identity));
                        tempFood.Add(Instantiate(sweets[Random.Range(0, 41)], new Vector3(x + temp1, y - temp2, 0.0f), Quaternion.identity));

                        Destroy(tempBangs.Last(), 30);
                        Destroy(tempFood.Last(), 30);
                        NetworkServer.Spawn(tempBangs.Last());
                        NetworkServer.Spawn(tempFood.Last());

                        break;
                    case 7:
                        tempBangs.Add(Instantiate(bangs[Random.Range(0, 3)], new Vector3(x - temp1, y + temp2, 0.0f), Quaternion.identity));
                        tempFood.Add(Instantiate(sweets[Random.Range(0, 41)], new Vector3(x - temp1, y + temp2, 0.0f), Quaternion.identity));

                        Destroy(tempBangs.Last(), 90);
                        Destroy(tempFood.Last(), 90);
                        NetworkServer.Spawn(tempBangs.Last());
                        NetworkServer.Spawn(tempFood.Last());

                        break;
                    case 8:
                        if (pumpkinCount < 1)
                        {
                            pumpkinCount++;
                            tempRings.Add(Instantiate(rings[1], new Vector3(x - temp1, y + temp2, 0.0f), Quaternion.identity));
                            tempPumpkin.Add(Instantiate(pumpkins[Random.Range(0, 2)], new Vector3(x - temp1, y + temp2, 0.0f), Quaternion.identity));

                            Destroy(tempRings.Last(), 40);
                            Destroy(tempPumpkin.Last(), 40);
                            NetworkServer.Spawn(tempRings.Last());
                            NetworkServer.Spawn(tempPumpkin.Last());

                        }
                        break;
                }
            }
        }
        pumpkinCount = 0;
        }
    }

    void GeneratePowerup()
    {
        if (!_ServerStopped)
        {
            if (GameObject.FindGameObjectsWithTag("Powerup").Length < maxSpawnsP)
            {
                RandomizePosition();

                tempRings.Add(Instantiate(rings[0], new Vector3(x, y, 0.0f), Quaternion.identity));
                tempPowerups.Add(Instantiate(powerups[Random.Range(0, 10)], new Vector3(x, y, 0.0f), Quaternion.identity));
                Destroy(tempRings.Last(), 60);
                Destroy(tempPowerups.Last(), 60);
                NetworkServer.Spawn(tempRings.Last());
                NetworkServer.Spawn(tempPowerups.Last());

            }
        }
    }

    void GenerateEnemy()
    {
        if (!_ServerStopped)
        {
            if (GameObject.FindGameObjectsWithTag("Enemy").Length < maxSpawnsE)
            {
                RandomizePosition();
                GameObject newEnemy = Instantiate(Enemy, new Vector3(x, y, 0.0f), Quaternion.identity);
                NetworkServer.Spawn(newEnemy);
            }
        }
    }
}
