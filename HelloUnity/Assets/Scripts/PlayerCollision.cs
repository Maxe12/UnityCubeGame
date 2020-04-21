using System;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    
    public PlayerMovement playerMovementRef;
    
    private void OnCollisionEnter(Collision collisionInfo)
    {
        if (!collisionInfo.collider.tag.Equals("Obstacle")) return;
        Debug.Log("Hit Obstacle!");
        playerMovementRef.enabled = false;
    }
}
