using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyFire : MonoBehaviour
{
    public GameObject Fire;
    public Transform startpos;
    public Enemies zapusk;
    bool zapuscheno = true;
    void Start()
    {
        zapusk = GameObject.FindGameObjectWithTag("Enemy").GetComponent<Enemies>();
    }
    void Update()
    {
        if (zapusk.distanceToTarget > 5)
        {
            if (zapuscheno == true)
            {
                Instantiate(Fire, startpos.position, Quaternion.identity);
                StartCoroutine(PIVO());
            }
        }
            
    }
    public IEnumerator PIVO()
    {
        zapuscheno = false;
        yield return new WaitForSeconds(2f);
        zapuscheno = true;
    }
}

