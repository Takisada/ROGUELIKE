using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BGEnemies : MonoBehaviour
{
    public bool DOOROPEN = false;
    public List<GameObject> list = new List<GameObject>();
    void Update()
    {
        if (list.Count == 0)
        {
            DOOROPEN = true;
        }
        else
        {
            DOOROPEN = false;
        }
    }
    void OnTriggerStay2D(Collider2D other)
    {
        for (int i = 0; i < list.Count; i++)
        {
            if(list[i] == null)
            {
                list.RemoveAt(i);
            }
        }
        if (other.tag == "Enemy" && !list.Contains(other.gameObject))
        {
            list.Add(other.gameObject);
        }
    }
}
