using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class choiced : MonoBehaviour {

    List<string> fourthchoice = new List<string>() { "28", "26", "48", "56", "13" };

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        if (textcontrol2.randQuestion > -1)
        {
            GetComponent<TextMesh>().text = fourthchoice[textcontrol2.randQuestion];

        }
    }
    void OnMouseDown()
    {
        textcontrol2.selectedAnswer = gameObject.name;
        textcontrol2.choiceSelected = "y";
    }
}
