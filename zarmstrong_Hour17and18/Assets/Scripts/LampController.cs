using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LampController : MonoBehaviour
{
    // Start is called before the first frame update
    private Animation anim;
    void Start()
    {
        anim = gameObject.GetComponent<Animation>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            anim.Stop("LampPosition");
            anim.Stop("LampScale");
            anim.Stop("LampSpin");
            anim.Play("LampColor");
        }
        if (Input.GetKeyDown(KeyCode.A))
        {
            anim.Stop("LampPosition");
            anim.Play("LampScale");
            anim.Stop("LampSpin");
            anim.Stop("LampColor");
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            anim.Stop("LampPosition");
            anim.Stop("LampScale");
            anim.Play("LampSpin");
            anim.Stop("LampColor");
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            anim.Play("LampPosition");
            anim.Stop("LampScale");
            anim.Stop("LampSpin");
            anim.Stop("LampColor");
        }
    }
}
