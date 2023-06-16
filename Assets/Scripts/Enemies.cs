using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemies : MonoBehaviour
{
    public float speed;
    public float chaseDistanse;
    public float stopDistance;
    public bool STORONA;
    private GameObject target;
    public float distanceToTarget;
    Animator animator;
    Rigidbody2D rigidbody1;
    void Start()
    {
        animator = GetComponent<Animator>();
        rigidbody1 = GetComponent<Rigidbody2D>();
        target = GameObject.FindGameObjectWithTag("Player");
    }

    void Update()
    {
        distanceToTarget = Vector2.Distance(transform.position, target.transform.position);
        if (distanceToTarget < chaseDistanse && distanceToTarget > stopDistance)
        {
            ChasingPlayer();
        }
        else
        {
            StopChasing();
        }
    }
    private void StopChasing()
    {
        animator.SetBool("IsWalking", false);
    }
    public void ChasingPlayer()
    {
        if (transform.position.x < target.transform.position.x)
        {
            GetComponent<SpriteRenderer>().flipX = false;
            STORONA = true;
        }
        else
        {
            GetComponent<SpriteRenderer>().flipX = true;
            STORONA = false;
        }
        transform.position = Vector2.MoveTowards(transform.position, target.transform.position, speed * Time.deltaTime);
        animator.SetBool("IsWalking", true);
    }
}

