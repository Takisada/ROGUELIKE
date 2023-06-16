using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    public float force = 1f;
    public GameObject Fire;
    public GameObject Fire2;
    public Transform startpos;
    public PlayerAttack pa;
    public float cooldown = 1f;
    // Update is called once per frame
    void Update()
    {
        float shootHor = Input.GetAxisRaw("ShootHorizontal");
        float shootVert = Input.GetAxisRaw("ShootVertical");
        if ((shootHor !=0 || shootVert != 0) && cooldown <= 0)
        {
            Shooting(shootHor, shootVert);
            cooldown = 1f;
        }
        cooldown -= Time.deltaTime;

    }
    void Shooting(float x, float y)
    {
        GameObject sna = Instantiate(y == 0f ? Fire : Fire2, startpos.position+new Vector3(x+0.3f, y+0.3f,0f) , y == 0f ? Fire.transform.rotation : Fire2.transform.rotation) as GameObject;
        sna.GetComponent<SpriteRenderer>().flipX = y == -1 || x == -1 ? true : false;
        sna.GetComponent<Rigidbody2D>().velocity = new Vector3(
            x * force,
            y * force,
            0);

    }

}
