using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class nxtbutton4 : MonoBehaviour {

    public static string resetAura = "n";

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    void OnMouseDown()
    {
        textcontrol4.randQuestion = -1;
        resetAura = "y";
    }
}
