using System.Collections;
using System.Collections.Generic;
using UnityEditor.SceneManagement;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class firstDoor : MonoBehaviour
{
    public GameObject secondDoor;
    public GameObject bigButton;
    public GameObject door;
    public GameObject Bevel;
    public GameObject Bevel1;
    public GameObject Bevel2;
    public Transform bigButtonTransform;
    public Transform characterTransform;
    public float interactionDistance;
    public float distance;
    public float timer;
    public float maxTimer;
    public int k;
    public Material materialBevel_true;
    public Material materialBevel_false;

    // Start is called before the first frame update
    void Start()
    {
        k = 1;
    }

    // Update is called once per frame
    void Update()
    {
        distance = Vector3.Distance(bigButtonTransform.position, characterTransform.position);

        timer = timer - 1 * Time.deltaTime;

        if (timer <= 0)
        {
            if(k == 0)
            {
                k += 1;
                bigButton.transform.Rotate(80, 0, 0);
            } 
            Bevel.GetComponent<MeshRenderer>().material = materialBevel_false;
            Bevel1.GetComponent<MeshRenderer>().material = materialBevel_false;
            Bevel2.GetComponent<MeshRenderer>().material = materialBevel_false;
            secondDoor.SetActive(true);
            timer = 0;
        }

        if(distance <= interactionDistance)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                if (k == 1)
                {
                    k = k - 1;
                    bigButton.transform.Rotate(-80, 0, 0);
                    Bevel.GetComponent<MeshRenderer>().material = materialBevel_true;
                    Bevel1.GetComponent<MeshRenderer>().material = materialBevel_true;
                    Bevel2.GetComponent<MeshRenderer>().material = materialBevel_true;
                    door.SetActive(false);
                    secondDoor.SetActive(false);
                    timer = maxTimer;
                }       
            }
        }

        if (distance > 300)
        {
            SceneManager.LoadScene("00");
        }
    }
}
