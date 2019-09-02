using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{

// TODO getcomponent on start
    public PlayerMovement playerMovement;
    private void OnCollisionEnter(Collision other)
    {
        if (other.collider.tag == "Obstacle")
        {
            playerMovement.enabled = false;
            FindObjectOfType<GameManager>().EndGame();
        }    
    }
}
