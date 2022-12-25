using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class CollectItemByDistance : MonoBehaviour
{
    public Transform characterTransform;
    public float interactionDistance;
    public float distance;
    public int legendary;
    public Text myText;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        distance = Vector3.Distance(transform.position, characterTransform.position);

        if (distance <= interactionDistance)
        {
            legendary += 1;
            myText.text = "Legendary " + $"{legendary}" + "/1";
            gameObject.SetActive(false);
            interactionDistance = -1;
        }
    }
}
