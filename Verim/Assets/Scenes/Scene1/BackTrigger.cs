using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackTrigger : MonoBehaviour
{
    public Transform CheckPoint;
    public Transform BallPoint;

    void OnTriggerEnter(Collider player)
    {
        if(player.tag == "Player")
        {
            player.GetComponent<CharacterController>().enabled = false;
            player.transform.position = CheckPoint.position;
            player.GetComponent<CharacterController>().enabled = true;
        }
        else
        {
            if (player.tag == "Item")
                player.transform.position = BallPoint.position;
        }
    }
}
