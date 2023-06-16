using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyInteractions : MonoBehaviour
{
    public bool KARTOFELINA;
    public Enemies bebra;
    Animator animator;
    public float health;
    public float damage;
    public Rigidbody2D rb;
    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody2D>();
        bebra = gameObject.GetComponent<Enemies>();
    }
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
        if (KARTOFELINA)
        {
            bebra.SHAIBA = true;
        }
    }
    void Death()
    {
        Destroy(gameObject);
    }
}
