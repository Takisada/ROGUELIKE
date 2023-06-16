using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System.IO;
using System.Linq;
public class Records : MonoBehaviour
{
   public TMP_Text text;
    void Start()
    {
        List<RECORDDATA> records = new List<RECORDDATA>();
        records = JSON.IzJSONFILE<RECORDDATA>(File.ReadAllText(Application.dataPath + "/Records.json")).ToList();
        for (int i = 0; i < records.Count; i++)
        {
            text.text += records[i].ToString();
        } 
    }
}
