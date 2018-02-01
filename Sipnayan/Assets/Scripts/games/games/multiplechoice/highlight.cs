using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class highlight : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}

    // Update is called once per frame
    void Update () {
		
	}

    void OnMouseOver()
    {
        GetComponent<TextMesh>().color = new Color(0, 0, 1);
        GetComponent<TextMesh>().fontSize = 54;
    }

    void OnMouseExit()
    {
        GetComponent<TextMesh>().color = new Color(0, 0, 0);
        GetComponent<TextMesh>().fontSize = 42;
    }
} 
