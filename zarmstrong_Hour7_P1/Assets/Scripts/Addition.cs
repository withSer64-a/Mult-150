using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Addition : MonoBehaviour
{
    // Start is called before the first frame update
    int a = 2;
    int b = 4;
    int c = 8;
    int sum;

     
    
    void Start()
    {
        sum = a + b + c;
        sum += 1;
        Debug.Log(sum);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
