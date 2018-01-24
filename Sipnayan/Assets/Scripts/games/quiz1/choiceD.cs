using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class choiceD : MonoBehaviour {

    List<string> fourthchoice = new List<string>() { "2","5","9","3","7","9","10","9","13","2" };

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        if (textcontrol1.randQuestion > -1)
        {
            GetComponent<TextMesh>().text = fourthchoice[textcontrol1.randQuestion];

        }
    }
    void OnMouseDown()
    {
        textcontrol1.selectedAnswer = gameObject.name;
        textcontrol1.choiceSelected = "y";
    }
}
