using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnableAndDisableScript : MonoBehaviour
{
    public void enableObject(GameObject gameObject)
    {
        if (!gameObject.active)
        {
            gameObject.SetActive(true);
        }
        else
        {
            gameObject.SetActive(false);
        }
    }
}
