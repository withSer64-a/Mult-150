using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        double health = 1004;
        double poisonDamage = 125.5;
        while (health > 0)
        {
            health -= poisonDamage;
            Debug.Log(health);
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
