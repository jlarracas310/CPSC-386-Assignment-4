using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaveState : MonoBehaviour
{
    public GameObject player;
    public GameObject saveMarker;
    private Vector3 savedPosition;
    private bool hasSavedPosition = false;
    private GameObject currentSaveMarker;

    private bool canSaveOrLoad = true; // Cooldown state
    private float cooldownTime = 1f;  // Cooldown duration in seconds

    private PlayerMovement playerMovement; // Reference to the player's movement script

    void Start()
    {
        // Get the player's movement script
        playerMovement = player.GetComponent<PlayerMovement>();
        if (playerMovement == null)
        {
            Debug.LogWarning("PlayerMovement script not found on player GameObject.");
        }
    }

    void Update()
    {
        // Save player position
        if (Input.GetKeyDown(KeyCode.K) && canSaveOrLoad)
        {
            SavePosition();
            StartCoroutine(Cooldown());
        }

        // Load player position
        if (Input.GetKeyDown(KeyCode.L) && canSaveOrLoad)
        {
            TeleportPlayer();
            StartCoroutine(Cooldown());
        }
    }

    // Save current position
    private void SavePosition()
    {
        savedPosition = player.transform.position;
        hasSavedPosition = true;
        Debug.Log("Player position saved at: " + savedPosition);

        DropSaveMaker();
    }

    // Teleport player instantly
    private void TeleportPlayer()
    {
        if (hasSavedPosition)
        {
            canSaveOrLoad = false;

            // Disable player movement
            if (playerMovement != null)
            {
                playerMovement.enabled = false;
            }

            // Move player to the saved position instantly
            player.transform.position = savedPosition;

            Debug.Log("Player teleported to: " + savedPosition);

            // Re-enable player movement
            if (playerMovement != null)
            {
                playerMovement.enabled = true;
            }

            DestroySaveMaker();
        }
        else
        {
            Debug.Log("No saved position to load.");
        }
    }

    // Drop Save Marker at saved position
    private void DropSaveMaker()
    {
        if (currentSaveMarker != null)
        {
            Destroy(currentSaveMarker);
        }

        currentSaveMarker = Instantiate(saveMarker, savedPosition, Quaternion.identity);
    }

    // Destroy current Save Marker
    private void DestroySaveMaker()
    {
        if (currentSaveMarker != null)
        {
            Destroy(currentSaveMarker);
            currentSaveMarker = null;
        }
    }

    // Cooldown coroutine to prevent spamming
    private IEnumerator Cooldown()
    {
        canSaveOrLoad = false; // Disable input
        yield return new WaitForSeconds(cooldownTime); // Wait for cooldown duration
        canSaveOrLoad = true; // Re-enable input
    }
}