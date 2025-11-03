using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log(other.gameObject.name + " has entered " + gameObject.name);
    }
    private void OnTriggerStay(Collider other)
    {
        Debug.Log(other.gameObject.name + " is still in " + gameObject.name);
    }
    private void OnTriggerExit(Collider other)
    {
        Debug.Log(other.gameObject.name + " has left " + gameObject.name);
    }
}
