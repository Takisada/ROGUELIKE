using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ENEMYSHOOTING : MonoBehaviour
{
    public float force = 100f;
    public float damage = 1f;
    public Enemies rotate;
    private Rigidbody2D snaryad;
    void Start()
    {
        snaryad = GetComponent<Rigidbody2D>();
        rotate = GameObject.FindGameObjectWithTag("Enemy").GetComponent<Enemies>();
        snaryad.AddForce((rotate.target.transform.position - transform.position).normalized*force);
        
        Destroy(gameObject, 2f);

    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            other.GetComponent<PlayerInteractions>().DamageTaken(damage);
            Destroy(gameObject);
        }
    }
}

