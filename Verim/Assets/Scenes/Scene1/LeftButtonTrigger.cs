using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeftButtonTrigger : MonoBehaviour
{
    public GameObject RightButton;
    public GameObject GreenLight;
    public GameObject RedLight;
    public GameObject Door;
    public Material Green;
    public Material Red;

    void OnTriggerEnter(Collider ball)
    {
        gameObject.GetComponent<Renderer>().material = Green;
        RedLight.SetActive(false);
        GreenLight.SetActive(true);
    }
    void OnTriggerExit(Collider ball)
    {
        gameObject.GetComponent<Renderer>().material = Red;
        GreenLight.SetActive(false);
        RedLight.SetActive(true);
        Door.SetActive(true);
    }

    void OnTriggerStay(Collider ball)
    {
        if (RightButton.tag == "Enabled")
            Door.SetActive(false);
        else 
            Door.SetActive(true);
    }
}
