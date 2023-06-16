using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RoomMove : MonoBehaviour
{
    public Vector3 camerachange;
    public Vector3 playerchange;
    private Camera cam;
    public float timer2;
    public static float timer;
    public PlayerInteractions dying;
    public BGEnemies BG;
    private GameObject Enemy;
    public static int lvlnum;

    // Start is called before the first frame update
    void Start()
    {
        cam = Camera.main.GetComponent<Camera>();
        timer = 0f;
        timer2 = 0f;

    }
    void Update()
    {
        lvlnum = SceneManager.GetActiveScene().buildIndex;
        dying = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerInteractions>();
        if (!dying.dead)
        {
            timer += Time.deltaTime;
            timer2 += Time.deltaTime;
        }
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (BG.DOOROPEN)
        {
            if (other.tag == "Player")
            {
                other.transform.position += playerchange;
                cam.transform.position += camerachange;
            }
        }
    }
    public static float gettime
    {
        get => timer/10f;
    }
    public static int getlvl
    {
        get => lvlnum;
    }
}
