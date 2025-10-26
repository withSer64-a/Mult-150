using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireBallScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int x = TakeDamageFromFireball();
        print("Player health: " + x);
        int y = TakeDamageFromFireball(25);
        print("Player Health: " + y);
        int z = TakeDamageFromFireball(30, 50);
        print("Player Health: " + z);
    }
    int TakeDamageFromFireball()
    {
        int PlayerHealth = 100;
        return PlayerHealth - 5;
    }
    int TakeDamageFromFireball(int damage)
    {
        int playerHealth = 100;
        return playerHealth - damage;
    }
    int TakeDamageFromFireball(int damage, int playerHealth)
    {
        return playerHealth - damage;
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
