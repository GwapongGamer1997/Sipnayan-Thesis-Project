using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class C : MonoBehaviour {

    List<string> thirdchoice = new List<string>() { "21,23,17,11,14", "5,6,7,4,9", "10,9,8,7,6", "7,8,9,10,11", "0,1,2,3,4",
		"12,1,2,34,21","2,3,1,0,4","8,4,5,1,5","9,21,2,23,24","19,21,22,23,24",
		"9,21,5,23,16","6,5,4,3,2","6,7,5,4,1","8,6,9,5,4","2,4,3,5,1"};

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        if (textcontrol4.randQuestion > -1)
        {
            GetComponent<TextMesh>().text = thirdchoice[textcontrol4.randQuestion];

        }
    }
    void OnMouseDown()
    {
        textcontrol4.selectedAnswer = gameObject.name;
        textcontrol4.choiceSelected = "y";
    }
}
