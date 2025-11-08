using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChaosGoalScript : MonoBehaviour
{
    // Start is called before the first frame update
    public bool isSolved = false;
    private void OnTriggerEnter(Collider collider)
    {
        GameObject collidedWith = collider.gameObject;
        if(collidedWith.tag == gameObject.tag)
        {
            isSolved = true;
            Destroy(collidedWith);
        }
    }
}
