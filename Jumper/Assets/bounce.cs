using UnityEngine;
using System.Collections;

public class Bouncing : MonoBehaviour
{
    void OnCollisionEnter(Collision col)
    {
        if(col.gameObject.tag == "player")
        {
            Debug.Log("Collision with player detected.");
            CharacterController controller = col.gameObject.GetComponent<CharacterController>();
            if (controller != null)
            {
                StartCoroutine(ApplyUpwardVelocity(controller));
            }
        }
    }

    private IEnumerator ApplyUpwardVelocity(CharacterController controller)
    {
        Vector3 velocity = new Vector3(0, 5, 0);
        float duration = 0.5f; // Duration for which the upward force is applied
        float elapsed = 0f;

        while (elapsed < duration)
        {
            controller.Move(velocity * Time.deltaTime);
            elapsed += Time.deltaTime;
            yield return null;
        }
    }
}