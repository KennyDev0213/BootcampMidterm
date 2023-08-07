using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    int damage = 10;
    public AudioSource hitSound;

    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log($"Bullet collided with {collision.gameObject.name}");

        //hitSound?.Play();

        IDestroyable destroyable = collision.gameObject.GetComponent<IDestroyable>();

        if (destroyable != null)
        {
            destroyable.OnCollided();
        }

        IDamageable damagable = collision.gameObject.GetComponent<IDamageable>();

        if (damagable != null)
        {
            damagable.Damage(damage);
        }

        //Destroy(gameObject);
    }
}
