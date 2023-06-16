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
        if (rotate.STORONA == false)
        {
            Vector3 scale = transform.localScale;
            scale.x *= -1;
            transform.localScale = scale;
            snaryad.AddForce(new Vector2(-force, 0f));
        }
        else if (rotate.STORONA == true)
        {
            snaryad.AddForce(new Vector2(force, 0f));
        }
        Destroy(gameObject, 1f);

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

