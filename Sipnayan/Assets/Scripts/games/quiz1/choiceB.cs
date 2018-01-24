using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class choiceB : MonoBehaviour {

    List<string> secondchoice = new List<string>() { "1","3","6","4","5","7","11","8","11","0" };

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        if (textcontrol1.randQuestion > -1)
        {
            GetComponent<TextMesh>().text = secondchoice[textcontrol1.randQuestion];

        }
    }
    void OnMouseDown()
    {
        textcontrol1.selectedAnswer = gameObject.name;
        textcontrol1.choiceSelected = "y";
    }
}
