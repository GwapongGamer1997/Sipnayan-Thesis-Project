using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class B : MonoBehaviour {

    List<string> secondchoice = new List<string>() { "1,2,3,4,5", "13,12,14,15,16", "0,9,8,5,3", "8,12,11,7,15", "22,32,12,11,4",
		"34,2,12,23,21","12,1,3,13,15","8,9,10,11,12","4,3,2,1,0","1,2,22,9,24",
		"6,7,8,9,1","1,2,3,4,5","3,6,4,2,1","30,29,28,27,26","7,9,4,3,2"};

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        if (textcontrol4.randQuestion > -1)
        {
            GetComponent<TextMesh>().text = secondchoice[textcontrol4.randQuestion];

        }
    }
    void OnMouseDown()
    {
        textcontrol4.selectedAnswer = gameObject.name;
        textcontrol4.choiceSelected = "y";
    }
}