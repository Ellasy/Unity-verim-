using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveablePlatform : MonoBehaviour
{
    public GameObject moveablePlatform;
    public float timerMoveablePlatform;
    public float maxTimerMoveablePlatform;
    public float speed;

    void Update()
    {
        timerMoveablePlatform = timerMoveablePlatform - 1 * Time.deltaTime;

        if (timerMoveablePlatform > 2)
        {
            moveablePlatform.transform.Translate(new Vector3(0, Time.deltaTime * speed, 0));
        }
        else
        {
            moveablePlatform.transform.Translate(new Vector3(0, -Time.deltaTime * speed, 0));
        }

        if (timerMoveablePlatform <= 0)
        {
            timerMoveablePlatform = maxTimerMoveablePlatform;
        }


    }
}
