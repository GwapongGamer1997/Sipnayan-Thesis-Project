using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class choice3 : MonoBehaviour {

    List<string> thirdchoice = new List<string>() { "Dogs", "5", "3", "6", "7" };

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        if (textcontrol3.randQuestion > -1)
        {
            GetComponent<TextMesh>().text = thirdchoice[textcontrol3.randQuestion];

        }
    }
    void OnMouseDown()
    {
        textcontrol3.selectedAnswer = gameObject.name;
        textcontrol3.choiceSelected = "y";
    }
}
