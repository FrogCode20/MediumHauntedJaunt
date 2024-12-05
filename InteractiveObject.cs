using UnityEngine;

public class InteractiveObject : MonoBehaviour
{
    public string message = "You found an interactive object!";
    public float interactionDistance = 3f; // The distance at which the player can interact
    private bool playerInRange = false;

    // Reference to the player object
    public GameObject player;

    void Update()
    {
        // Check the distance between the player and the interactive object
        float distance = Vector3.Distance(player.transform.position, transform.position);

        if (distance <= interactionDistance)
        {
            if (!playerInRange)
            {
                playerInRange = true;
                ShowMessage();
            }
        }
        else
        {
            if (playerInRange)
            {
                playerInRange = false;
                HideMessage();
            }
        }
    }

    void ShowMessage()
    {
        // Show the message or trigger any other action
        Debug.Log(message);
        // You can replace Debug.Log with any UI display code to show the message in the UI
    }

    void HideMessage()
    {
        // Hide the message or stop any actions that were triggered
        Debug.Log("Player left the interaction range.");
        // You can add any code here to hide the UI message if used
    }
}
