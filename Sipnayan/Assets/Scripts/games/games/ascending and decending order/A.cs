using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class A : MonoBehaviour {

    List<string> firstchoice = new List<string>() { "10,13,11,14,9", "2,4,9,12,11", "30,31,32,33,34", "23,12,31,24,21", "6,8,7,9,10",
		"34,35,36,32,33","15,16,17,18,19","12,18,13,19,20","21,22,23,24,25","10,9,8,7,6",
		"8,9,10,4,7","4,3,5,6,7","14,13,12,11,10","5,4,3,1,2","5,6,7,4,1"};

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
        if (textcontrol4.randQuestion>-1)
        {
            GetComponent<TextMesh>().text = firstchoice[textcontrol4.randQuestion];

        }

	}
    void OnMouseDown()
    {
        textcontrol4.selectedAnswer = gameObject.name;
        textcontrol4.choiceSelected = "y";
    }
}
