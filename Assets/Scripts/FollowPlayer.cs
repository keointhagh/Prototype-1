using UnityEngine;

public class FollowPlayer : MonoBehaviour
{

    public GameObject player; // Reference to the player GameObject
    private Vector3 offset; //New Vector3(0, 5, -7); // Offset between the player and this GameObject

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        if(gameObject.CompareTag("MainCamera"))
        {
            offset = new Vector3(0, 6, -9);
        } else if(gameObject.CompareTag("DriverCamera"))
        {
            offset = new Vector3(0, 2, 0.5f);
        }

    }

    // Update is called once per frame
    void LateUpdate()
    {
        transform.position = player.transform.position + offset; // Set the position of this GameObject to the player's position
    }
}
