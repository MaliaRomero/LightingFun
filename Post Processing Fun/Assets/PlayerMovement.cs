using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed = 5f; // The speed at which the player moves

    // Update is called once per frame
    void Update()
    {
        // Get the horizontal and vertical input
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        // Calculate the direction the player should move in
        Vector3 direction = new Vector3(-horizontalInput, 0f, verticalInput);

        // Normalize the direction to prevent faster diagonal movement
        if (direction.magnitude > 1f)
        {
            direction = direction.normalized;
        }

        // Calculate movement vector
        Vector3 movement = new Vector3(horizontalInput, 0f, verticalInput).normalized * moveSpeed * Time.deltaTime;

        // Move player
        transform.position += movement;
    }
}
