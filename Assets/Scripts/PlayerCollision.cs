using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    public PlayerMovement movement;
  
    public void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == "Obstacle")
        {
            movement.enabled = false;
            FindAnyObjectByType<GameManager>().EndGame();
          
        }
        

    }
}
