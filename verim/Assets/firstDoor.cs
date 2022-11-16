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
    public GameObject bridge;
    public GameObject moveablePlatform;
    public GameObject door;
    public GameObject key;
    public GameObject legendaryDrop;
    public GameObject Bevel;
    public GameObject Bevel1;
    public GameObject Bevel2;
    public Transform legendaryTransform;
    public Transform keyTransform;
    public Transform bigButtonTransform;
    public Transform characterTransform;
    public float interactionDistance;
    public float distance;
    public float distance1;
    public float distance2;
    public float timer;
    public float timerBridge;
    public float timerMoveablePlatform;
    public float maxTimer;
    public float maxTimerBridge;
    public float maxTimerMoveablePlatform;
    public float speed;
    public int k;
    public int legendary;
    public Material materialBevel_true;
    public Material materialBevel_false;
    public Text myText;

    // Start is called before the first frame update
    void Start()
    {
        k = 1;
    }

    // Update is called once per frame
    void Update()
    {
        distance2 = Vector3.Distance(legendaryTransform.position, characterTransform.position);

        distance1 = Vector3.Distance(keyTransform.position, characterTransform.position);

        distance = Vector3.Distance(bigButtonTransform.position, characterTransform.position);

        timer = timer - 1 * Time.deltaTime;

        timerBridge = timerBridge - 1 * Time.deltaTime;

        timerMoveablePlatform = timerMoveablePlatform - 1 * Time.deltaTime;

        if (timer <= 0)
        {
            if(k == 0)
            {
                bigButton.transform.Rotate(80, 0, 0);
                k += 1;
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
                bigButton.transform.Rotate(-80, 0, 0);
                Bevel.GetComponent<MeshRenderer>().material = materialBevel_true;
                Bevel1.GetComponent<MeshRenderer>().material = materialBevel_true;
                Bevel2.GetComponent<MeshRenderer>().material = materialBevel_true;
                door.SetActive(false);
                secondDoor.SetActive(false);
                timer = maxTimer;
                k = k - 1;
            }
        }

        if(distance1 <= interactionDistance)
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
          
        if (distance2 <= interactionDistance)
        {
            legendary += 1;
            myText.text = "Legendary 1/1";
            legendaryDrop.SetActive(false);
        }

        if(timerMoveablePlatform > 2)
        {
            moveablePlatform.transform.Translate(new Vector3(0, Time.deltaTime * speed, 0));
        }
        else
        {
            moveablePlatform.transform.Translate(new Vector3(0, -Time.deltaTime * speed, 0));
        }

        if(timerMoveablePlatform <= 0)
        {
            timerMoveablePlatform = maxTimerMoveablePlatform;
        }

        if (distance > 300)
        {
            SceneManager.LoadScene("00");
        }
    }
}
