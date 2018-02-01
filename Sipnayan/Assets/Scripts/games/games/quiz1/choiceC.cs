using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class choiceC : MonoBehaviour {

    List<string> thirdchoice = new List<string>() { "3","4","8","2","6","6","9","10","12","3" };

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        if (textcontrol1.randQuestion > -1)
        {
            GetComponent<TextMesh>().text = thirdchoice[textcontrol1.randQuestion];

        }
    }
    void OnMouseDown()
    {
        textcontrol1.selectedAnswer = gameObject.name;
        textcontrol1.choiceSelected = "y";
    }
}

