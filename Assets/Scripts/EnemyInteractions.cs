using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyInteractions : MonoBehaviour
{
    Animator animator;
    public float health;
    public float damage;

    void OnTriggerEnter2D(Collider2D other)
    {
        animator = GetComponent<Animator>();
        if (other.tag == "Player")
        {
            other.GetComponent<PlayerInteractions>().DamageTaken(damage);
        }

    }
    public void DamageTaken(float damagedealed)
    {
        health -= damagedealed;
        if (health <= 0f)
        {
            Death();
        }
    }
    void Death()
    {
        Destroy(gameObject);
    }
}
