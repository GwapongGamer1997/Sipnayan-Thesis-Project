using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class choice1 : MonoBehaviour {

    List<string> firstchoice = new List<string>() { "Birds", "2", "6", "7", "6" };

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
        if (textcontrol3.randQuestion>-1)
        {
            GetComponent<TextMesh>().text = firstchoice[textcontrol3.randQuestion];

        }

	}
    void OnMouseDown()
    {
        textcontrol3.selectedAnswer = gameObject.name;
        textcontrol3.choiceSelected = "y";
    }
}
