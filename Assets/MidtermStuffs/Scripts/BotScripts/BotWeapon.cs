using UnityEngine;

public class BotWeapon{

    private int damage;

    Health targetHealth;

    public BotWeapon(Health health){
        targetHealth = health;
        damage = 10;
    }

    public BotWeapon(Health health, int damage){
        targetHealth = health;
        this.damage = damage;
    }

    public void Use()
    {
        targetHealth.DeductHealth(damage);
    }
    
}