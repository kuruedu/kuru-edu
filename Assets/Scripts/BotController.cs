using UnityEngine;
using System.Collections;

public class BotController : MonoBehaviour {

	private TileController TC;
	public int currentPos = 0;
	public int finalPos = 0;
	public float speed = 5.0f;
	public bool isfinal = false;
	public bool inTurn = false;
	private bool playerHasMoveTrig = false;
	private SoundController AC;

	public Animator BotAnimator;
	public SpriteRenderer PlayerSprite;
	// Use this for initialization
	void Start () {
		TC = GameObject.Find ("GameManager").GetComponent<TileController> ();
		AC = GameObject.Find ("AudioManager").GetComponent<SoundController> ();
	}
	
	// Update is called once per frame
	void Update () {
		transform.position = Vector3.Lerp(transform.position, TC.Tiles [currentPos].transform.position, Time.deltaTime * speed);
		/*
		if (!playerHasMoveTrig) {
			if (GameObject.FindObjectOfType<PlayerController> ().inTurn == true) {
				playerHasMoveTrig = true;
			}
		}
		if (GameObject.FindObjectOfType<PlayerController> ().inTurn == false) {
			inTurn = true;
		}

		if (playerHasMoveTrig && inTurn) {
			if (GameObject.FindObjectOfType<PlayerController> ().inTurn == false) {
				moveBotNext ();
			}
		}
		*/

		flipPlayerAtPos ();

		if (currentPos == 100) {
			if (!isfinal) {
				GameObject.FindObjectOfType<QuizGenerator> ().YouWin.SetActive (true);
				GameObject.FindObjectOfType<ScoreController> ().winStatus (2);
				isfinal = true;
			}
		}
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

	public void moveBotNext(){
		if (!isfinal) {
			//playerHasMoveTrig = false;
			//inTurn = false;
			GameObject.FindObjectOfType<CamController>().target = this.gameObject.transform;
			GameObject.FindObjectOfType<DiceController> ().daduOBJ.SetActive (false);
			finalPos += Random.Range(1,6);
			StartCoroutine(moveStepbyStep());
		}
	}

	public IEnumerator moveStepbyStep(){
		currentPos += 1;
		AC.playSFX (2);
		BotAnimator.SetTrigger ("Move");
		yield return new WaitForSeconds (1);
		checkPosition ();
	}

	public void checkPosition(){
		if (currentPos != finalPos) {
			StartCoroutine (moveStepbyStep ());
		} else {
			//playerHasMoveTrig = false;
			//inTurn = false;
			GameObject.FindObjectOfType<PlayerController>().ButtonMaju.SetActive(true);
			GameObject.FindObjectOfType<CamController> ().target = GameObject.Find ("PlayerPrototype").transform;
			GameObject.FindObjectOfType<DiceController> ().daduOBJ.SetActive (true);
		}
	}
}
