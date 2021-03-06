using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class textcontrol4 : MonoBehaviour {

	List<string> questions = new List<string>() {"1.Choose the number which have\nASCENDING order!!",
		"2.Choose the number which have\nASCENDING order!!",
		"3.Choose the number which have\nASCENDING order!!",
		"4.Choose the number which have\nASCENDING order!!",
		"5.Choose the number which have\nASCENDING order!!",
		"6.Choose the number which have\nASCENDING order!!",
		"7.Choose the number which have\nASCENDING order!!",
		"8.Choose the number which have\nASCENDING order!!",
		"9.Choose the number which have\nDECENDING order!!",
		"10.Choose the number which have\nDECENDING order!!",
		"11.Choose the number which have\nDECENDING order!!",
		"12.Choose the number which have\nDECENDING order!!",
		"13.Choose the number which have\nDECENDING order!!",
		"14.Choose the number which have\nDECENDING order!!",
		"15.Choose the number which have\nDECENDING order!!",};

	List<string> correctAnswer = new List<string>() { "B","D", "A", "C","C","D","A","B","B","A","D","C","A","B","D" };

	List<int> previousQuestions = new List<int>() {-1, -1, -1, -1, -1, -1, -1, -1, -1, -1,-1, -1, -1, -1, -1, -1, -1, -1, -1, -1};
    public int questionNumber = 0;

    public Transform resultObj;

    public Transform auraObj;

    public static string selectedAnswer;

    public static string choiceSelected = "n";

    public static int randQuestion=-1;

    public float totalCorrect = 0;
    public float totalQuestions = 0;
    public Transform scoreObj;
    public float scorePer;

   

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        //scoreObj.GetComponent<TextMesh>().text = "Score :" + totalCorrect;

       // if (totalQuestions > 0)
      //  {
       //    scorePer = (totalCorrect / totalQuestions) * 100;
       // }
        

		scoreObj.GetComponent<TextMesh>().text = "Score : " + totalCorrect;

        if (randQuestion == -1)
        {
            randQuestion = Random.Range(0, 15);
            for (int i = 0; i < 20; i++)
            {
                if (randQuestion != previousQuestions [i])
                {

                }
                else
                {
                    randQuestion = -1;
                }  
            }
        }
        if (randQuestion>-1)
        {
            GetComponent<TextMesh>().text = questions[randQuestion];
            previousQuestions [questionNumber] = randQuestion;
        }
        if (choiceSelected=="y")
        {
            choiceSelected = "n";
            totalQuestions += 1;
            questionNumber += 1;

            if (correctAnswer[randQuestion]==selectedAnswer)
            {
                resultObj.GetComponent<TextMesh>().text = "Correct!! Click Next to Continue";
                totalCorrect += 1;
            }
            else
            {
                nxtbutton4.resetAura = "n";
                resultObj.GetComponent<TextMesh>().text = "Incorrect!! Click Next to Continue";
                    
                if(correctAnswer[randQuestion]== "A")
                {
                    auraObj.GetComponent<Transform>().position = new Vector3(-22.6f, 15f, 72);
                }
                if (correctAnswer[randQuestion] == "B")
                {
                    auraObj.GetComponent<Transform>().position = new Vector3(-23.6f, 6f, 72);
                }
                if (correctAnswer[randQuestion] == "C")
                {
                    auraObj.GetComponent<Transform>().position = new Vector3(-22.6f, -1f, 72);
                }
                if (correctAnswer[randQuestion] == "D")
                {
                    auraObj.GetComponent<Transform>().position = new Vector3(-22.4f, -8f, 72);
                }
            }

        }
	}
}
