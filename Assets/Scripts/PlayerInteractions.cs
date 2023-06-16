using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerInteractions : MonoBehaviour
{
    public float health = 6f;
    public float damage = 3.5f;
    public bool dead;
    Animator animator;

    public void DamageTaken(float damagedealed)
    {
        health -= damagedealed;
        if (health <= 0f)
        {
            dead = true;
            animator = GetComponent<Animator>();
            animator.SetBool("IsDead", true);
            Death();
        }
        dead = false;
    }

    public void Death()
    {
        SceneManager.LoadScene(0);
    }
}
