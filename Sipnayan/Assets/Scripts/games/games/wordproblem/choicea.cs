using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class choicea : MonoBehaviour {

    List<string> firstchoice = new List<string>() { "25", "29", "46", "59", "11" };

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
        if (textcontrol2.randQuestion>-1)
        {
            GetComponent<TextMesh>().text = firstchoice[textcontrol2.randQuestion];

        }

	}
    void OnMouseDown()
    {
        textcontrol2.selectedAnswer = gameObject.name;
        textcontrol2.choiceSelected = "y";
    }
}
