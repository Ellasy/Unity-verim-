using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RocketTrigger : MonoBehaviour
{
    public float speed;
    public bool ButtonLaunch;

    void OnTriggerStay(Collider other)
    {
        if(Input.GetKeyDown(KeyCode.E))
            ButtonLaunch = true;
    }

    void Update()
    {
        if(ButtonLaunch == true)
        {
            Vector3 RocketLaunch = new Vector3(0, 1, 0);
            transform.position = transform.position + RocketLaunch * speed * Time.deltaTime;
        }        
    }
}
