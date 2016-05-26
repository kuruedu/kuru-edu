using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class PlayerControlMulti : MonoBehaviour {

	private SoundController AC;

	public int currentPos = 0;
	public int idMove; //0 kiri 1 kanan
	public int finalPos;
	public bool isQuiz, isfinal, isTeleport;
	public int getDadu;
	public Button RollButton;
	public Text DiceShow;
	public float speed = 5.0f;
	public bool inTurn = false;

	public GameObject ButtonMaju;

	private TileController TC;
	private DiceController DC;
	public QuizGeneratorMulti QG;
	public TeleportController Tele;

	private Animator theDice;
	public Animator PlayerAnim;
	public SpriteRenderer PlayerSprite;

	public bool inMove = false;

	// Use this for initialization
	void Start () {
		ButtonMaju.SetActive (true);
		TC = GameObject.Find ("GameManager").GetComponent<TileController> ();
		DC = GameObject.Find ("GameManager").GetComponent<DiceController> ();
		//QG = GameObject.Find ("GameManager").GetComponent<QuizGenerator> ();
		AC = GameObject.Find ("AudioManager").GetComponent<SoundController> ();
		//Tele = GameObject.Find ("GameManager").GetComponent<TeleportController> ();
		RollButton.onClick.AddListener (getDiceRoll);

		theDice = GameObject.Find ("Dice").GetComponent<Animator> ();
	}

	// Update is called once per frame
	void Update () {
		transform.position = Vector3.Lerp(transform.position, TC.Tiles [currentPos].transform.position, Time.deltaTime * speed);
		QuizZoneChecker ();
		print ("Current Pos : " + currentPos + " / Your Dice : " + getDadu + " / Final Pos : " + finalPos);
		flipPlayerAtPos ();
	}

	void flipPlayerAtPos(){
		if (currentPos >= 0 && currentPos <= 10) {
			PlayerSprite.flipX = false;
		}
		if (currentPos >= 11 && currentPos <= 20) {
			PlayerSprite.flipX = true;
		}
		if (currentPos >= 21 && currentPos <= 30) {
			PlayerSprite.flipX = false;
		}
		if (currentPos >= 31 && currentPos <= 40) {
			PlayerSprite.flipX = true;
		}
		if (currentPos >= 41 && currentPos <= 50) {
			PlayerSprite.flipX = false;
		}
		if (currentPos >= 51 && currentPos <= 60) {
			PlayerSprite.flipX = true;
		}
		if (currentPos >= 61 && currentPos <= 70) {
			PlayerSprite.flipX = false;
		}
		if (currentPos >= 71 && currentPos <= 80) {
			PlayerSprite.flipX = true;
		}
		if (currentPos >= 81 && currentPos <= 90) {
			PlayerSprite.flipX = false;
		}
		if (currentPos >= 91 && currentPos <= 100) {
			PlayerSprite.flipX = true;
		}
	}


	public void QuizZoneChecker(){
		if (!inMove) {
			if (!isQuiz) {
				if (finalPos == TC.QuizZoneNum[0] || finalPos == TC.QuizZoneNum[1] || finalPos == TC.QuizZoneNum[2] || finalPos == TC.QuizZoneNum[3] || finalPos == TC.QuizZoneNum[4] || finalPos == TC.QuizZoneNum[5] || finalPos == TC.QuizZoneNum[6] || finalPos == TC.QuizZoneNum[7] || finalPos == TC.QuizZoneNum[8] || finalPos == TC.QuizZoneNum[9] ) {
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
				if (finalPos == TC.TeleZoneNum [0] || finalPos == TC.TeleZoneNum [1] || finalPos == TC.TeleZoneNum [2] || finalPos == TC.TeleZoneNum [3] || finalPos == TC.TeleZoneNum [4]) {
					AC.playSFX (1);
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
			ButtonMaju.SetActive (false);
		}
	}

	public void DiceRollMove(){
		if (currentPos + 1 + getDadu < TC.Tiles.Length) {
			//currentPos +=getDadu;
			finalPos = currentPos + getDadu;
			inMove = true;
			inTurn = true;
			QG.yourScore += 1;
			GameObject.FindObjectOfType<ScoreController> ().addScore (1);
			StartCoroutine (moveStepbyStep ("right"));
			DiceShow.text = "" + getDadu;
			idMove = 1;
		} else {
			inMove = false;
			inTurn = false;
			StartCoroutine (MoveBot ());
			print ("Finish");
			AC.playSFX (5);
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
		AC.playSFX (5);
		finalPos = currentPos - getDadu;
		inMove = true;
		inTurn = true;
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
		PlayerAnim.SetTrigger ("Move");
		//this.GetComponent<Animator> ().SetTrigger ("Move");
		yield return new WaitForSeconds (1);
		//GameObject.Find ("Dice").GetComponent<Animator> ().SetInteger ("RollNum", 0);
		GameObject.FindObjectOfType<DiceController>().daduOBJ.GetComponent<Animator>().SetInteger ("RollNum", 0);
		checkPosition ();

	}

	public void MovePlayerRight(){
		currentPos += 1;
		AC.playSFX (2);
		inTurn = true;
	}

	public void MovePlayerLeft(){
		currentPos -= 1;
		AC.playSFX (2);
		inTurn = true;
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
			inTurn = false;
			ButtonMaju.SetActive(true);
			//GameObject.FindObjectOfType<CamController> ().target = GameObject.Find ("PlayerPrototype").transform;
			GameObject.FindObjectOfType<DiceController> ().daduOBJ.SetActive (true);
		}
	}

	IEnumerator MoveBot(){
		ButtonMaju.SetActive (false);
		yield return new WaitForSeconds (2);
		GameObject.FindObjectOfType<BotController> ().moveBotNext ();
	}
}
