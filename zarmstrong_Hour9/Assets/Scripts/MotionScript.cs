using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MotionScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        
        if (Input.GetKey(KeyCode.UpArrow) == true)
        {
            transform.Translate(0, .01f, 0);
        }
        if (Input.GetKey(KeyCode.DownArrow) == true)
        {
            transform.Translate(0, -.01f, 0);
        }
        if (Input.GetKey(KeyCode.LeftArrow) == true)
        {
            transform.Translate(-.01f, 0, 0);
        }
        if (Input.GetKey(KeyCode.RightArrow) == true)
        {
            transform.Translate(.01f, 0, 0);
        }
    }
}
