using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    //Скорость бега
    public int MovementSpeed = 1;
    //Вектора движения.
    float horizontalvectorvalue;
    float verticalvectorvalue;
    //Разворот модели героя на 180
    public bool FLIPSIDE = true;
    Animator animator;
    // Start is called before the first frame update
    void Awake()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        horizontalvectorvalue = Input.GetAxis("Horizontal");
        verticalvectorvalue = Input.GetAxis("Vertical");
    }
    void FixedUpdate()
    {
        Vector3 Movement = new Vector3(horizontalvectorvalue * MovementSpeed, verticalvectorvalue * MovementSpeed, 0.0f);
        transform.position = transform.position + Movement * Time.deltaTime;
        animator.SetFloat("MoveSpeed", Mathf.Abs(horizontalvectorvalue != 0 ? horizontalvectorvalue : verticalvectorvalue));
        Flip(horizontalvectorvalue);
    }
    private void Flip(float horizontalvectorvalue)
    {
        if (horizontalvectorvalue < 0 && !FLIPSIDE || horizontalvectorvalue > 0 && FLIPSIDE)
        {
            FLIPSIDE = !FLIPSIDE;

            Vector3 scale = transform.localScale;
            scale.x *= -1;
            transform.localScale = scale;
        }
    }
}
