using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject powerupPrefab;
    public GameObject obstaclePrefab;
    public float spawnCycle = .25f;

    GameManager manager;
    float elapsedTime;
    bool spawnPowerup = true;
    int powerupTimer = 4;
    float obstacleScale;
    // Start is called before the first frame update
    void Start()
    {
        manager = GetComponent<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        elapsedTime += Time.deltaTime;
        if (elapsedTime > spawnCycle)
        {
            if (powerupTimer == 4)
            {
                spawnPowerup = true;
                powerupTimer = 0;
            }
            else
            {
                spawnPowerup = false;
            }
                GameObject temp;
            if (spawnPowerup)
                temp = Instantiate(powerupPrefab) as GameObject;
            else
                temp = Instantiate(obstaclePrefab) as GameObject;

            Vector3 position = temp.transform.position;
            position.x = Random.Range(-3f, 3f);
            temp.transform.position = position;
            obstacleScale = Random.Range(0f, .2f);
            Vector3 scale = temp.transform.localScale;
            temp.transform.localScale += new Vector3(obstacleScale, obstacleScale, obstacleScale);

            Collidable col = temp.GetComponent<Collidable>();
            col.manager = manager;


            powerupTimer += 1;
            elapsedTime = 0;
            
        }

    }
}
