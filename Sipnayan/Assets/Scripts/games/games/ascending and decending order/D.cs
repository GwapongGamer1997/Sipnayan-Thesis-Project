using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class D : MonoBehaviour {

    List<string> fourthchoice = new List<string>() { "3,1,5,2,4", "23,24,25,26,27", "23,13,19,21,28", "5,7,2,1,9", "19,21,22,23,24",
		"2,3,4,5,6","7,3,1,2,8","9,2,1,6,4","3,14,5,18,12","19,21,5,7,1",
		"20,19,18,17,16","6,5,1,3,2","8,7,6,4,3","9,8,7,4,5","7,6,5,4,3"};

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        if (textcontrol4.randQuestion > -1)
        {
            GetComponent<TextMesh>().text = fourthchoice[textcontrol4.randQuestion];

        }
    }
    void OnMouseDown()
    {
        textcontrol4.selectedAnswer = gameObject.name;
        textcontrol4.choiceSelected = "y";
    }
}
