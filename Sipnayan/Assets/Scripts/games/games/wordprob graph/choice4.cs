using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class choice4 : MonoBehaviour {

    List<string> fourthchoice = new List<string>() { "Fish", "6", "4", "5", "4" };

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        if (textcontrol3.randQuestion > -1)
        {
            GetComponent<TextMesh>().text = fourthchoice[textcontrol3.randQuestion];

        }
    }
    void OnMouseDown()
    {
        textcontrol3.selectedAnswer = gameObject.name;
        textcontrol3.choiceSelected = "y";
    }
}
