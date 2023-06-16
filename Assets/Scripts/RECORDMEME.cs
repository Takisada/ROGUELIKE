using System.IO;
using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RECORDMEME : MonoBehaviour
{
    public static List<RECORDDATA> recordiki = new List<RECORDDATA>();
    // Start is called before the first frame update
    void Start()
    {
        if (File.Exists(Application.dataPath + "/Records.json"))
        {
            recordiki = JSON.IzJSONFILE<RECORDDATA>(File.ReadAllText(Application.dataPath + "/Records.json")).ToList();
        }
    }

    public static void AddScore()
    {
        recordiki.Add(new RECORDDATA(RoomMove.getlvl, RoomMove.gettime));
        Debug.Log(recordiki[0].recordlvl.ToString() + " " + recordiki[0].times.ToString());
    }
    public static void SaveScore()
    {
        File.WriteAllText(Application.dataPath + "/Records.json", JSON.toJsonfile<RECORDDATA>(recordiki.ToArray()));
    }
    public static float PEREBOR(int k)
    {
       for(int i = 0; i < recordiki.Count; i++)
       {
            if (k == recordiki[i].recordlvl)
            {
                return recordiki[i].times;
            }
       }
        return 0;
    }
    public static float DEL(int k)
    {
        for (int i = 0; i < recordiki.Count; i++)
        {
            if (k == recordiki[i].recordlvl)
            {
                recordiki.RemoveAt(i);
            }
        }
        return 0;
    }
}
