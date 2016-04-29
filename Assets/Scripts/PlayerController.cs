﻿using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour {
	private SoundController AC;

	public int currentPos = 0;
	public int idMove; //0 kiri 1 kanan
	public int finalPos;
	public bool isQuiz, isfinal, isTeleport;
	public int getDadu;
	public Button RollButton;
	public Text DiceShow;
	public float speed = 5.0f;

	private TileController TC;
	private DiceController DC;
	private QuizGenerator QG;
	private TeleportController Tele;

	private Animator theDice;

	private bool inMove = false;

	// Use this for initialization
	void Start () {
		TC = GameObject.Find ("GameManager").GetComponent<TileController> ();
		DC = GameObject.Find ("GameManager").GetComponent<DiceController> ();
		QG = GameObject.Find ("GameManager").GetComponent<QuizGenerator> ();
		AC = GameObject.Find ("AudioManager").GetComponent<SoundController> ();
		Tele = GameObject.Find ("GameManager").GetComponent<TeleportController> ();
		RollButton.onClick.AddListener (getDiceRoll);

		theDice = GameObject.Find ("Dice").GetComponent<Animator> ();
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
				if (finalPos == 5 || finalPos == 10 || finalPos == 13 || finalPos == 17 || finalPos == 21 || finalPos == 33 || finalPos == 44 || finalPos == 50 || finalPos == 55 || finalPos == 60 || finalPos == 70 || finalPos == 75 || finalPos == 82 || finalPos == 86 || finalPos == 90 || finalPos == 93 || finalPos == 96) {
					isQuiz = true;
					AC.playSFX (1);
					QG.GenerateQuiz (Random.Range (1, 81));
				} else {
					isQuiz = false;
				}
			}
			if (!isfinal) {
				if (finalPos == 100) {
					currentPos += 1;
					AC.playSFX (1);
					QG.GenerateQuiz (Random.Range (1, 81));
					isfinal = true;
				}
			}
			if (!isTeleport) {
				if (finalPos == 18 || finalPos == 26 || finalPos == 42 || finalPos == 68 || finalPos == 79 || finalPos == 98) {
					Tele.openTeleportMenu ();
					isTeleport = true;
				}
			}

		}
	}

	public bool rollAnimationDone(){
		if ( 
			theDice.GetCurrentAnimatorStateInfo (0).IsName ("Roll1") &&
			theDice.GetCurrentAnimatorStateInfo (0).IsName ("Roll2") &&
			theDice.GetCurrentAnimatorStateInfo (0).IsName ("Roll3") &&
			theDice.GetCurrentAnimatorStateInfo (0).IsName ("Roll4") &&
			theDice.GetCurrentAnimatorStateInfo (0).IsName ("Roll5") &&
			theDice.GetCurrentAnimatorStateInfo (0).IsName ("Roll1")) {
			return true;
		} else {
			return false;
		}
	}

	public void getDiceRoll(){
		if (!inMove) {
			getDadu = DC.PutarDadu ();
			AC.playSFX (3);
			StartCoroutine(playDiceAnim());
		}
	}

	public void DiceRollMove(){
		if (currentPos + 1 + getDadu < TC.Tiles.Length) {
			//currentPos +=getDadu;
			finalPos = currentPos + getDadu;
			inMove = true;
			QG.yourScore += 1;
			GameObject.FindObjectOfType<ScoreController> ().addScore (1);
			StartCoroutine (moveStepbyStep ("right"));
			DiceShow.text = "" + getDadu;
			idMove = 1;
		} else {
			print ("Finish");
		}
	}


	IEnumerator playDiceAnim(){
		GameObject.Find ("Dice").GetComponent<Animator> ().SetInteger ("RollNum", getDadu);
		yield return new WaitForSeconds (1.0f);
		GameObject.Find ("Dice").GetComponent<Animator> ().SetInteger ("RollNum", 0);
		yield return new WaitForSeconds (1.0f);
		DiceRollMove ();
	}

	public void moveNextBenarJawab(){
		if (!isfinal) {
			AC.playSFX (4);
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
		GameObject.Find ("Dice").GetComponent<Animator> ().SetInteger ("RollNum", 0);
		checkPosition ();

	}

	public void MovePlayerRight(){
		currentPos += 1;
		AC.playSFX (2);
	}

	public void MovePlayerLeft(){
		currentPos -= 1;
		AC.playSFX (2);
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
