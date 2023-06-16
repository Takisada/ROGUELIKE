using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DOORS : MonoBehaviour
{
    public PlayerInteractions dying;
    public static float timer;
    public bool DOOROPEN;
    public bool lvlcleared;
    private GameObject Enemy;
    public int scenenum;
    public int RND;
    public int RND2;
    public int BOSS;
    public int BOSS2;
    public static int lvlnum;

    void Start()
    {
        timer = SHIP.timers;
    }
    void Update()
    {
        lvlnum = SHIP.lvlnum;
        dying = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerInteractions>();
        if (!dying.dead)
        {
            timer += Time.deltaTime;
        }
        BOSS = 4;
        BOSS2 = 5;
        scenenum = SceneManager.GetActiveScene().buildIndex;
        Enemy = GameObject.FindGameObjectWithTag("Enemy");
        if (Enemy == null)
        {
            DOOROPEN = true;
        }
        else
        {
            DOOROPEN = false;
        }
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        
        RND = Random.Range(2, 4);
        RND2 = Random.Range(4, 6);
        if (DOOROPEN)
        {
            if(other.tag == "Player")
            {
                if(scenenum == 1)
                {
                   SceneManager.LoadScene(RND);
                   SHIP.timers = timer;
                }
                else if(scenenum == 2 || scenenum == 3)
                {
                    if (lvlnum == 2)
                    {
                        SceneManager.LoadScene(BOSS2);
                        SHIP.timers = timer;
                    }
                    else if (lvlnum == 1)
                    {
                        SceneManager.LoadScene(BOSS);
                        SHIP.timers = timer;
                    }
                    else
                    {
                       SceneManager.LoadScene(RND2);
                        SHIP.timers = timer;
                    }
                }
                else if (scenenum == 4 || scenenum == 5)
                {
                    float pastrezult = RECORDMEME.PEREBOR(lvlnum);
                    if (pastrezult > timer || pastrezult == 0)
                    {
                        Debug.Log("OK");
                        if (pastrezult > timer)
                        {
                            RECORDMEME.DEL(lvlnum);
                        }
                        RECORDMEME.AddScore();
                        RECORDMEME.SaveScore();
                    }
                    SHIP.timers = 0f;
                    timer = 0f;
                    SceneManager.LoadScene(1);
                    lvlnum++;
                    SHIP.lvlnum = lvlnum;
                }
            }
        }
    }
    public static float gettime
    {
        get =>  SHIP.timers;
    }
    public static int getlvl
    {
        get =>  lvlnum+1;
    }
}
