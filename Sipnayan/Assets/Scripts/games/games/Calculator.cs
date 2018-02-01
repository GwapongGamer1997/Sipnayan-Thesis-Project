using System.Collections;
using System.Collections.Generic;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using UnityEngine;

public class Calculator : MonoBehaviour {

    [SerializeField]
    Text inputField;

    string inputString;
    int[] number = new int[4];
    string operatorSymbol;
    int i = 0;
    int result;
    bool displayedResults = false;

    public void ButtonPressed()
    {
        if (displayedResults == true)
        {
            inputField.text = "";
            inputString = "";
            displayedResults = false;      
        }
       
        string buttonValue = EventSystem.current.currentSelectedGameObject.name;
        inputString += buttonValue;

        int arg; 
        if(int.TryParse(buttonValue, out arg))
        {
            if (i > 0) i = 0;
            number[i] = arg;
            i = i + 1;
        }
        else
        {
            switch(buttonValue)
            { 
                case "+":
                    operatorSymbol = buttonValue;
                    break;
                case "-":
                    operatorSymbol = buttonValue;
                    break;
                case "*":
                    operatorSymbol = buttonValue;
                    break;
                case "/":
                    operatorSymbol = buttonValue;
                    break;

                case "=":
                    switch (operatorSymbol)
                    {
                        case "+":
                            result = number[0] + number[1] ;
                            break;
                        case "-":
                            result = number[0] - number[1];
                            break;
                        case "*":
                            result = number[0] * number[1];
                            break;
                        case "/":
                            result = number[0] / number[1];
                            break;
                    }

                    displayedResults = true;
                    inputString = result.ToString();
                    number = new int[4];
                    break;
            }
        }
        inputField.text = inputString;
    }
}
