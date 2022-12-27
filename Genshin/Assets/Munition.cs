using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Munition : MonoBehaviour
{
    public GameObject ShootPoint;

    void Update()
    {
        transform.position = ShootPoint.transform.position + Vector3.forward * Time.deltaTime;
    }
}
