using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttack : MonoBehaviour
{
    public float force = 100f;
    public float damage = 1f;
    public PlayerMovement rotate;
    private Rigidbody2D snaryad;
    void Start()
    {
        snaryad = GetComponent<Rigidbody2D>();
        
      Destroy(gameObject, 1f);

    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Enemy")
        {
            other.GetComponent<EnemyInteractions>().DamageTaken(damage);
            Destroy(gameObject);
        }
    }
}

