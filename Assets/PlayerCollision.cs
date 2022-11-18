using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    void OnCollisionEnter(Collision collisionInfo)
    {
        if (collisionInfo.collider.tag == "Red")
        {
            Debug.Log("we hit Red Ball");
        }

        if (collisionInfo.collider.tag == "Green")
        {
            Debug.Log("we hit Green Ball");
        }

        if (collisionInfo.collider.tag == "Blue")
        {
            Debug.Log("we hit Blue Ball");
        }
    }
}
