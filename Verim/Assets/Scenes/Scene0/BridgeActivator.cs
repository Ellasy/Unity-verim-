using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class BridgeActivator : MonoBehaviour
{
    public GameObject bridge;
    public GameObject key;
    public Transform keyTransform;
    public Transform characterTransform;
    public float timerBridge;
    public float maxTimerBridge;
    public float interactionDistance;
    public float distance;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        distance = Vector3.Distance(keyTransform.position, characterTransform.position);
        timerBridge = timerBridge - 1 * Time.deltaTime;
        keyTransform.transform.Rotate(0, 0, Time.deltaTime * 60);

        if (distance <= interactionDistance)
        {
            bridge.SetActive(true);
            timerBridge = maxTimerBridge;
            key.SetActive(false);

        }

        if (timerBridge <= 0)
        {
            bridge.SetActive(false);
            key.SetActive(true);
            timerBridge = 0;
        }

    }
}
