using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlayerStatus : MonoBehaviour
{
    private Rigidbody2D rgidbdy;
    private Animator anim;

    [SerializeField] private AudioSource deathSoundEffect;
    [SerializeField] private Text deathCounterText; // Reference to UI Text for death counter

    private int deathCount; // Track the number of deaths
    private const string DeathCountKey = "PlayerDeathCount"; // PlayerPrefs key

    private void Start()
    {
        rgidbdy = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();

        // Load death count from PlayerPrefs
        deathCount = PlayerPrefs.GetInt(DeathCountKey, 0);
        UpdateDeathCounterUI();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            Die();
        }
    }

    private void Die()
    {
        // Play death sound and animation
        deathSoundEffect.Play();
        rgidbdy.bodyType = RigidbodyType2D.Static;
        anim.SetTrigger("Death");

        // Increment death count, save it, and update UI
        deathCount++;
        PlayerPrefs.SetInt(DeathCountKey, deathCount);
        PlayerPrefs.Save();
        UpdateDeathCounterUI();

        // Restart the level after a delay
        Invoke(nameof(RestartLevel), 1f);
    }

    private void RestartLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    private void UpdateDeathCounterUI()
    {
        if (deathCounterText != null)
        {
            deathCounterText.text = "DEATHS: " + deathCount;
        }
        else
        {
            Debug.LogWarning("Death Counter Text is not assigned!");
        }
    }

    public void ResetDeathCount()
    {
        deathCount = 0;
        PlayerPrefs.SetInt(DeathCountKey, deathCount);
        PlayerPrefs.Save();
        UpdateDeathCounterUI();
    }
}