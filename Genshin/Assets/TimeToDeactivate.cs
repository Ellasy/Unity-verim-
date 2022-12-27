using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeToDeactivate : MonoBehaviour
{
    public float timeToDie = 0.1f;

    void Update()
    {
        timeToDie = timeToDie - 1 * Time.deltaTime;
        if (timeToDie <= 0)
            Destroy(gameObject);
    }
}
