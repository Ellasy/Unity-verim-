using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RightButtonTrigger : MonoBehaviour
{
    public GameObject GreenLight;
    public GameObject RedLight;
    public Material Green;
    public Material Red;

    void OnTriggerEnter(Collider ball)
    {
        gameObject.GetComponent<Renderer>().material = Green;
        transform.gameObject.tag = "Enabled";
        RedLight.SetActive(false);
        GreenLight.SetActive(true);
    }
    void OnTriggerExit(Collider ball)
    {
        gameObject.GetComponent<Renderer>().material = Red;
        transform.gameObject.tag = "Disabled";
        GreenLight.SetActive(false);
        RedLight.SetActive(true);
    }
}
