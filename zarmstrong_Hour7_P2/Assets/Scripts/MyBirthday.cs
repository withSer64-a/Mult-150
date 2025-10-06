using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyBirthday : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int day = 1;
        while(day <= 30)
        {
            
            if(day == 29)
            {
                Debug.Log("Its my birthday!");
            }
            else
            {
                Debug.Log(day);
            }
                day++;

        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
