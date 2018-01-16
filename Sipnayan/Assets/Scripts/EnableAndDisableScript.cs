using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnableAndDisableScript : MonoBehaviour
{
    public GameObject gameObject;

    public void enableObject()
    {
        if (!gameObject.active)
        {
            gameObject.SetActive(true);
        }
    }
}
