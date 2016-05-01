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
		if (currentPos == 100) {
			if (!isfinal) {
				GameObject.FindObjectOfType<QuizGenerator> ().YouWin.SetActive (true);
				GameObject.FindObjectOfType<ScoreController> ().winStatus (2);
				isfinal = true;
			}
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
