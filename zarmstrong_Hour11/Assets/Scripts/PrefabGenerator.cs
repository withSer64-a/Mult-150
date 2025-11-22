using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrefabGenerator : MonoBehaviour
{
    public GameObject prefab;
    private Vector3 position;
    // Start is called before the first frame update
    
    void Start()
    {
        float i = 0;
        while(i < 10){
            position = new Vector3(i, 0, 0);
            Instantiate(prefab, position, transform.rotation);
            Debug.Log(position);
            i += 1;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.B))
        {
            Instantiate(prefab);
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(prefab, transform.position, transform.rotation);
            
        }
    }
}
