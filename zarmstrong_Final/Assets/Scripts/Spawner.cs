using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject powerupPrefab;
    public GameObject obstaclePrefab;
    public GameObject catPrefab;
    public GameObject donutPrefab;
    public float spawnCycle = .25f;

    GameManager manager;
    float elapsedTime;
    int powerupTimer = 4;
    int donutTimer = 0;
    int catTimer = 0;
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
        GameObject temp;
        if (elapsedTime > spawnCycle)
        {
            if (powerupTimer == 4)
            {
                powerupTimer = 0;
                temp = Instantiate(powerupPrefab) as GameObject;
            }
            else if(catTimer == 18)
            {
                temp = Instantiate(catPrefab) as GameObject;
                catTimer = 0;
            }
            else if (donutTimer == 19)
            {
                temp = Instantiate(donutPrefab) as GameObject;
                donutTimer = 0;
            }
            else
            {
                temp = Instantiate(obstaclePrefab) as GameObject;

            }


                Vector3 position = temp.transform.position;
            position.x = Random.Range(-3f, 3f);
            temp.transform.position = position;
            obstacleScale = Random.Range(0f, .2f);
            Vector3 scale = temp.transform.localScale;
            if (temp == obstaclePrefab)
            {
                temp.transform.localScale += new Vector3(obstacleScale, obstacleScale, obstacleScale);
            }

            Collidable col = temp.GetComponent<Collidable>();
            col.manager = manager;


            powerupTimer += 1;
            catTimer += 1;
            donutTimer += 1;
            elapsedTime = 0;
            
        }

    }
}
