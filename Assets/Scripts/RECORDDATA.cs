using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class RECORDDATA
{
    public int recordlvl;
    public float times;

    public RECORDDATA(int lvl, float time)
    {
        recordlvl = lvl;
        times = time;
    }
}
