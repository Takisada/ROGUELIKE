using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class JSON
{
    public static T[] IzJSONFILE<T>(string json)
    {
        Wrapper<T> wrapper = JsonUtility.FromJson<Wrapper<T>>(json);
        return wrapper.Items;
    }
    public static string toJsonfile<T>(T[] mas)
    {
        Wrapper<T> wrapper = new Wrapper<T>();
        wrapper.Items = mas;
        return JsonUtility.ToJson(wrapper);
    }
    [System.Serializable]
    private class Wrapper<T>
    {
        public T[] Items;
    }
}
