using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class textcontrol3 : MonoBehaviour {

	List<string> questions = new List<string>() { "Which pet did the greatest number\nof students choose?",
		"How many students chose birds?",
		"How many more students chose\ndogs than cats?",
		"How many more students chose\ndogs than birds?",
		"How many students chose cats?"};

    List<string> correctAnswer = new List<string>() { "C", "A", "D", "B","A" };

    List<int> previousQuestions = new List<int>() {-1, -1, -1, -1, -1, -1, -1, -1, -1, -1};
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
            randQuestion = Random.Range(0, 5);
            for (int i = 0; i < 10; i++)
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
                nxtbutton1.resetAura = "n";
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
