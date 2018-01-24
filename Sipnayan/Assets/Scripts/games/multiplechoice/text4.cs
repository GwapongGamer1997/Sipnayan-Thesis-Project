using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class text4 : MonoBehaviour {

    List<string> fourthchoice = new List<string>() { "4", "4", "5", "5", "4" };

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        if (textcontrol.randQuestion > -1)
        {
            GetComponent<TextMesh>().text = fourthchoice[textcontrol.randQuestion];

        }
    }
    void OnMouseDown()
    {
        textcontrol.selectedAnswer = gameObject.name;
        textcontrol.choiceSelected = "y";
    }
}
