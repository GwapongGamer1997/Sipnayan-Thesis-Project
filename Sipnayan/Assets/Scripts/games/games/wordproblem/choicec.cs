using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class choicec : MonoBehaviour {

    List<string> thirdchoice = new List<string>() { "27", "27", "47", "57", "14" };

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        if (textcontrol2.randQuestion > -1)
        {
            GetComponent<TextMesh>().text = thirdchoice[textcontrol2.randQuestion];

        }
    }
    void OnMouseDown()
    {
        textcontrol2.selectedAnswer = gameObject.name;
        textcontrol2.choiceSelected = "y";
    }
}
