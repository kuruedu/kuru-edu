using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour {
	//public SoundController SoundScript;

	public int currentPos = 0;
	public int idMove; //0 kiri 1 kanan
	public int finalPos;
	public bool isQuiz, isfinal;
	public int getDadu;
	public Button RollButton;
	public Text DiceShow;
	public float speed = 5.0f;

	private TileController TC;
	private DiceController DC;
	private QuizGenerator QG;

	private bool inMove = false;

	// Use this for initialization
	void Start () {
		TC = GameObject.Find ("GameManager").GetComponent<TileController> ();
		DC = GameObject.Find ("GameManager").GetComponent<DiceController> ();
		QG = GameObject.Find ("GameManager").GetComponent<QuizGenerator> ();
		RollButton.onClick.AddListener (getDiceRoll);
	}
	
	// Update is called once per frame
	void Update () {
		transform.position = Vector3.Lerp(transform.position, TC.Tiles [currentPos].transform.position, Time.deltaTime * speed);

		QuizZoneChecker ();

		print ("Current Pos : " + currentPos + " / Your Dice : " + getDadu + " / Final Pos : " + finalPos);

	}

	public void QuizZoneChecker(){
		if (!inMove) {
			if (!isQuiz) {
				if (finalPos == 5 || finalPos == 10 || finalPos == 13 || finalPos == 17 || finalPos == 21) {
					isQuiz = true;
					QG.GenerateQuiz (Random.Range (1, 21));
				} else {
					isQuiz = false;
				}
			}
			if (finalPos == 100) {
				currentPos += 1;
				QG.GenerateQuiz (Random.Range (1, 21));
				isfinal = true;
			}
		}
	}

	public void getDiceRoll(){
		if (!inMove) {
			getDadu = DC.PutarDadu ();
			QG.yourScore += 1;
			if (currentPos + 1 + getDadu < TC.Tiles.Length) {
				//currentPos +=getDadu;
				finalPos = currentPos + getDadu;
				inMove = true;
				StartCoroutine (moveStepbyStep ("right"));
				DiceShow.text = "" + getDadu;
				idMove = 1;
			} else {
				print ("Finish");
			}
		}
	}

	public void moveNextBenarJawab(){
		if (!isfinal) {
			currentPos += 1;
			finalPos += 1;
		}
	}

	public void moveBackSalahJawab(){
		finalPos = currentPos - getDadu;
		inMove = true;
		StartCoroutine (moveStepbyStep ("left"));
		idMove = 0;
	}

	public IEnumerator moveStepbyStep(string direction){
		if (direction.Equals ("right")) {
			MovePlayerRight ();
		}
		if (direction.Equals ("left")) {
			MovePlayerLeft ();
		}
		yield return new WaitForSeconds (1);
		checkPosition ();

	}

	public void MovePlayerRight(){
		currentPos += 1;
		//SoundScript.playSFX (0);
	}

	public void MovePlayerLeft(){
		currentPos -= 1;
	}

	public void checkPosition(){
		if (currentPos != finalPos) {
			if (idMove == 1) {
				StartCoroutine (moveStepbyStep ("right"));
			}
			if (idMove == 0) {
				StartCoroutine (moveStepbyStep ("left"));
			}
		} else {
			inMove = false;
		}
	}

}
