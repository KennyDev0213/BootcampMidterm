using UnityEngine;

public class BotHealth : MonoBehaviour, IDamageable {
    
    public int maxHealth = 100, health;

    private void Start() {
        health = maxHealth;
    }

    public void AddHealth(int amount)
    {
        health += amount;

        if (health > maxHealth)
        {
            health = maxHealth;
        }
    }

    public void Damage(int amount)
    {
        AddHealth(-amount);

        if (health <= 0)
        {
            //die
            Destroy(gameObject);
        }
    }
}