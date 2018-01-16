using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class id : MonoBehaviour
{
    public static id _instance;
    public string Uid
    {
        get;
        private set;
    }

    public static id Instance
    {
        get
        {
            if (_instance == null)
            {
                GameObject go = new GameObject("user_id");
                go.AddComponent<id>();
            }
            return _instance;
        }
    }

    void Awake()
    {
        _instance = this;
        Uid = UsersScript.Userid;
        DontDestroyOnLoad(this);
    }
}
