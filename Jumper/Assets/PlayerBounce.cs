using UnityEngine;

public class PlayerBounce : MonoBehaviour
{
    private CharacterController controller;
    private Vector3 velocity;
    private float gravity = -9.81f;

    private void Start()
    {
        controller = GetComponent<CharacterController>();
        if (controller == null)
        {
            Debug.LogError($"No CharacterController found on {gameObject.name}! Make sure PlayerBounce is on the correct object.");
        }
    }

    private void Update()
    {
        if (controller == null) return;  // Prevent errors

        if (controller.isGrounded && velocity.y < 0)
        {
            velocity.y = -2f;  // Prevents sinking into the ground
        }

        velocity.y += gravity * Time.deltaTime; // Apply gravity
        controller.Move(velocity * Time.deltaTime);
    }

    public void ApplyBounce(Vector3 bounceVelocity)
    {
        if (controller != null)
        {
            Debug.Log($"Bounce applied with force: {bounceVelocity}");
            velocity = bounceVelocity;
        }
    }
}
