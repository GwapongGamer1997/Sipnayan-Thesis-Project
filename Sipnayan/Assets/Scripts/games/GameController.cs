using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour {

	private int num;
	private int guessNumber;

	private int countGuess;

	[SerializeField]
	private Text text;

	[SerializeField]
	private GameObject btn;

	[SerializeField]
	private InputField input;

	void Awake() {
		num = Random.Range(0, 50);
		text.text = "Guess A Number Between 0 and 50";

	}
	 
	public void GetInput(string guess) {
		CompareGuesses (int.Parse(guess));
		input.text = "";
		countGuess++;
	}
	void CompareGuesses(int guess) {
		if (guess == num) {
			text.text = "You Guessed Correctly The Number Was " + guess + "It took you " + countGuess + "Gues(ess) " + "Do you want to play again?";
			btn.SetActive (true);
		} else if (guess < num) {
			text.text = "Your Guess Number is Less Than The Number You Are Trying To guess";
		} else if (guess > num) {
			text.text = "Your Guess Number is Greater Than The Number You Are Trying To guess";
		}

	}
	public void PlayAgain() {
		num = Random.Range(0, 50);
		text.text = "Guess A Number Between 0 and 50";
		countGuess = 0;
		btn.SetActive (false);
	}
}
