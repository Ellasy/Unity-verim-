using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;

public class LaserGun : MonoBehaviour
{
    public ScanCameraActivator ScanCameraActivatorScript;
    public float range;
    public float damage;
    public float fireRate;
    public AudioSource ShootAudio;
    public AudioClip ShootClip;
    public GameObject ShootingLight;

    void Update()
    {
        if (ScanCameraActivatorScript.InScanMode == false)
        {
            if(Input.GetMouseButtonDown(0))
            {
                Shoot();
            }
        }
    }

    void Shoot()
    {
        ShootAudio.PlayOneShot(ShootClip);
        Instantiate(ShootingLight, transform.position, transform.rotation);

        RaycastHit hit;

        if (Physics.Raycast(transform.position, transform.forward, out hit, range))
            Debug.Log("Нанёс дамаг по " + $"{hit.collider}");

        if (hit.rigidbody != null)
        {
            hit.rigidbody.AddForce(-hit.normal * damage);
        }
    }
}
