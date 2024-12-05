using UnityEngine;
using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour
{
    public int maxHealth = 100; // Max health of the player
    private int currentHealth;

    public Slider healthSlider; // Reference to the UI Slider for the health bar

    void Start()
    {
        currentHealth = maxHealth;
        UpdateHealthSlider();
    }

    void Update()
    {
        // You can add checks for when health reaches 0, etc. here
    }

    public void TakeDamage(int damage)
    {
        currentHealth -= damage;
        if (currentHealth < 0) currentHealth = 0;

        UpdateHealthSlider();

        // Check if the player is dead
        if (currentHealth <= 0)
        {
            Die();
        }
    }

    void UpdateHealthSlider()
    {
        if (healthSlider != null)
        {
            healthSlider.value = (float)currentHealth / maxHealth;
        }
    }

    void Die()
    {
        Debug.Log("Player died!");
        // You can add game over logic or reset the level here
    }
}
