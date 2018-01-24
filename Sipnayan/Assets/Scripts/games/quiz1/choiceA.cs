using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class choiceA : MonoBehaviour {

    List<string> firstchoice = new List<string>() { "4", "2", "7", "5", "4", "8", "12", "7", "10", "1" };

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        if (textcontrol1.randQuestion > -1)
        {
            GetComponent<TextMesh>().text = firstchoice[textcontrol1.randQuestion];

        }

    }
    void OnMouseDown()
    {
        textcontrol1.selectedAnswer = gameObject.name;
        textcontrol1.choiceSelected = "y";
    }
}
