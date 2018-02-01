using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 
using System.Linq;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {

	public Question[] questions;

	private static List<Question> unansweredQuestions;

	private Question currentQuestion;



	[SerializeField]  
	private Text factText;

	[SerializeField]
	private Text TrueAnswerText;

	[SerializeField]
	private Text FalseAnswerText;

	[SerializeField]
	private Animator animator;



	[SerializeField]
	private float timeBetweenQuestions;
	void Start ()
	{
		

		if (unansweredQuestions == null || unansweredQuestions.Count == 0)
		{
			unansweredQuestions = questions.ToList<Question> ();
		}
			 
		SetCurrentQuestion (); 

	
	}
	void SetCurrentQuestion ()
	{
		int randomQuestionIndex = Random.Range (0, unansweredQuestions.Count);
		currentQuestion = unansweredQuestions[randomQuestionIndex];

		factText.text = currentQuestion.fact;

		if (currentQuestion.isTrue) {
			TrueAnswerText.text = "Your Right";
			FalseAnswerText.text = "Your Wrong";


		} else
		{
			TrueAnswerText.text = "Your Wrong";
			FalseAnswerText.text = "Your Right";
		}

	}

	IEnumerator TransitionoNextQuestion()
	{
		unansweredQuestions.Remove(currentQuestion);
		yield return new WaitForSeconds (timeBetweenQuestions); 

		SceneManager.LoadScene (SceneManager.GetActiveScene().buildIndex);
	}

	public void UserSelectTrue()
	{
		
		animator.SetTrigger ("True");
		if (currentQuestion.isTrue) 
		{

		} else
		{
			
		}
		StartCoroutine (TransitionoNextQuestion ());
	}

	public void UserSelectFalse()
	{
		animator.SetTrigger ("False");
		if (!currentQuestion.isTrue) 
		{

		} else
		{
			
		}
		StartCoroutine (TransitionoNextQuestion ());
	} 
		
}
