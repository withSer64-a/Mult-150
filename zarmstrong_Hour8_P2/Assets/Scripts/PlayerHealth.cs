using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int healthpoints = 3992;
        healthpoints = UsePotion(healthpoints);
        healthpoints = UsePotion(healthpoints);
        healthpoints = UsePotion(healthpoints);
        healthpoints = UsePotion(healthpoints);
        healthpoints = UsePotion(healthpoints);
        Debug.Log(healthpoints);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    int UsePotion(int health)
    {
        health += 400;
        return health;

    }
}
