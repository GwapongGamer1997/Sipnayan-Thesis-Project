using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour {

	private int num;

	private int countGuess;

	[SerializeField]
	private GameObject btn;

	[SerializeField]
	private InputField input;

	[SerializeField]
	private Text text;

	void Awake() {
		num = Random.Range (0, 20);
		text.text = "Guess A Number Between 0 and 20";
	}

	public void GetInput (string guess) {
		CompareGuesses (int.Parse(guess));
		input.text = "";
		countGuess++;
	}

	void CompareGuesses(int guess) {
		if (guess == num) {
			text.text = "You Guessed Correctly The Number Was " + guess + " It Took You "  + countGuess +  " Guess(ess) Do You Want To Play Again?";
			btn.SetActive (true);
		} else if (guess < num) {
			text.text = "Your Guess Number is Less Than The Number You are Trying to Guess";
		} else if (guess > num) {
			text.text = "Your Guess Number is Greater Than The Number You are Trying to Guess";
		}
			
	}

	public void Playback() {
		num = Random.Range (0, 20);
		text.text = "Guess A Number Between 0 and 20";
		countGuess = 0;
		btn.SetActive (false);
	}
}
