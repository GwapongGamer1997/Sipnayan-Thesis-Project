using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class text3 : MonoBehaviour {

    List<string> thirdchoice = new List<string>() { "3", "2", "4", "3", "7" };

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        if (textcontrol.randQuestion > -1)
        {
            GetComponent<TextMesh>().text = thirdchoice[textcontrol.randQuestion];

        }
    }
    void OnMouseDown()
    {
        textcontrol.selectedAnswer = gameObject.name;
        textcontrol.choiceSelected = "y";
    }
}
