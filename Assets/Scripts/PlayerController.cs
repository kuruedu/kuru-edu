using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour {

	public int currentPos = 0;
	public bool isQuiz, isfinal;
	public int getDadu;
	public Button RollButton;
	public Text DiceShow;

	private TileController TC;
	private DiceController DC;
	private QuizGenerator QG;

	// Use this for initialization
	void Start () {
		TC = GameObject.Find ("GameManager").GetComponent<TileController> ();
		DC = GameObject.Find ("GameManager").GetComponent<DiceController> ();
		QG = GameObject.Find ("GameManager").GetComponent<QuizGenerator> ();
		RollButton.onClick.AddListener (moveToNext);
	}
	
	// Update is called once per frame
	void Update () {
		/*
		if (Input.GetMouseButtonDown(0)) {
			moveToNext ();
		}
		*/
		transform.position = Vector3.Lerp(transform.position, TC.Tiles [currentPos].transform.position, Time.deltaTime);

		if (!isQuiz) {
			if (currentPos == 5 || currentPos == 10 || currentPos == 13 || currentPos == 17 || currentPos == 21) {
				isQuiz = true;
				QG.GenerateQuiz (Random.Range (1, 21));
			} else {
				isQuiz = false;
			}
		}
		if (currentPos == 25) {
			currentPos += 1;
			QG.GenerateQuiz (Random.Range (1, 21));
			isfinal = true;
		}

	}

	public void moveToNext(){
		getDadu = DC.PutarDadu ();
		QG.yourScore += 1;
		if (currentPos + 1 + getDadu < TC.Tiles.Length) {
			currentPos +=getDadu;
			//this.transform.position = TC.Tiles [currentPos].transform.position;
			DiceShow.text = ""+getDadu;
		} else {
			print ("Finish");
		}
	}


}
