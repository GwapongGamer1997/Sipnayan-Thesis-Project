using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class nxtbutton : MonoBehaviour {

    public static string resetAura = "n";

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    void OnMouseDown()
    {
        textcontrol2.randQuestion = -1;
        resetAura = "y";
    }
}
