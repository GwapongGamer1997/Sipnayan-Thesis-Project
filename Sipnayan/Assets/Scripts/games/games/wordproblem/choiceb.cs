using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class choiceb : MonoBehaviour {

    List<string> secondchoice = new List<string>() { "26", "28", "45", "58", "12" };

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        if (textcontrol2.randQuestion > -1)
        {
            GetComponent<TextMesh>().text = secondchoice[textcontrol2.randQuestion];

        }
    }
    void OnMouseDown()
    {
        textcontrol2.selectedAnswer = gameObject.name;
        textcontrol2.choiceSelected = "y";
    }
}