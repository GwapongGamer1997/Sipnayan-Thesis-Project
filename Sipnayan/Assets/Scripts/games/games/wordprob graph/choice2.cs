using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class choice2 : MonoBehaviour {

    List<string> secondchoice = new List<string>() { "Cats", "3", "2", "8", "5" };

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        if (textcontrol3.randQuestion > -1)
        {
            GetComponent<TextMesh>().text = secondchoice[textcontrol3.randQuestion];

        }
    }
    void OnMouseDown()
    {
        textcontrol3.selectedAnswer = gameObject.name;
        textcontrol3.choiceSelected = "y";
    }
}