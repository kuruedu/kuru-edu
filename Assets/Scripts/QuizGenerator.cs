using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class QuizGenerator : MonoBehaviour {

	public int correct;

	public Text soalNya;
	public Button pilA;
	public Button pilB;
	public Button pilC;
	public Button pilD;

	public Text Score;
	public int yourScore = 0;

	public GameObject QuizTime;
	public GameObject YouWin;
	public Text youWinScore;

	// Use this for initialization
	void Start () {
		pilA.onClick.AddListener (delegate { Answering(1); } );
		pilB.onClick.AddListener (delegate { Answering(2); } );
		pilC.onClick.AddListener (delegate { Answering(3); } );
		pilD.onClick.AddListener (delegate { Answering(4); } );
		QuizTime.SetActive (false);
		YouWin.SetActive (false);
	}

	void Update(){
		Score.text = "Score : " + yourScore;
		youWinScore.text = "Score : " + yourScore;
	}
	
	public void GenerateQuiz(int soal){
		QuizTime.SetActive (true);
		if (soal == 1) {
			soalNya.text = "Berapa 5 + 5 ?";
			pilA.GetComponentInChildren<Text>().text = "11";
			pilB.GetComponentInChildren<Text>().text = "10";
			pilC.GetComponentInChildren<Text>().text = "5";
			pilD.GetComponentInChildren<Text>().text = "0";

			correct = 2;
		}
		if (soal == 2) {
			soalNya.text = "Mana kah yang benar ?";
			pilA.GetComponentInChildren<Text>().text = "Allah adalah tuhan";
			pilB.GetComponentInChildren<Text>().text = "Kucing bisa terbang";
			pilC.GetComponentInChildren<Text>().text = "Ban Kereta bisa Kempes";
			pilD.GetComponentInChildren<Text>().text = "Ayam Menyelam";

			correct = 1;
		}
		if (soal == 3) {
			soalNya.text = "Matahari dibutuhkan Tanaman untuk ?";
			pilA.GetComponentInChildren<Text>().text = "Apa?";
			pilB.GetComponentInChildren<Text>().text = "Mati";
			pilC.GetComponentInChildren<Text>().text = "Fotosintesis";
			pilD.GetComponentInChildren<Text>().text = "Tidur";

			correct = 3;
		}
		if (soal == 4) {
			soalNya.text = "Jakarta adalah ?";
			pilA.GetComponentInChildren<Text>().text = "Coba";
			pilB.GetComponentInChildren<Text>().text = "Coba";
			pilC.GetComponentInChildren<Text>().text = "Negara";
			pilD.GetComponentInChildren<Text>().text = "Ibu Kota Indonesia";

			correct = 4;
		}

	}

	public void Answering(int ans){
		if (ans == 1) {
			if (ans == correct) {
				//benar
				print("benar");
				if (GameObject.Find ("PlayerPrototype").GetComponent<PlayerController> ().isfinal) {
					YouWin.SetActive (true);
				} else {
					GameObject.Find ("PlayerPrototype").GetComponent<PlayerController> ().currentPos += 1;
				}
				GameObject.Find ("PlayerPrototype").GetComponent<PlayerController> ().isQuiz = false;
				QuizTime.SetActive (false);
				yourScore += 10;
			} else {
				//salah
				print("salah");
				GameObject.Find ("PlayerPrototype").GetComponent<PlayerController> ().currentPos -= GameObject.Find ("PlayerPrototype").GetComponent<PlayerController> ().getDadu;
				GameObject.Find ("PlayerPrototype").GetComponent<PlayerController> ().isQuiz = false;
				QuizTime.SetActive (false);
				yourScore -= 5;
			}
		}
		if (ans == 2) {
			if (ans == correct) {
				//benar
				print("benar");
				if (GameObject.Find ("PlayerPrototype").GetComponent<PlayerController> ().isfinal) {
					YouWin.SetActive (true);
				} else {
					GameObject.Find ("PlayerPrototype").GetComponent<PlayerController> ().currentPos += 1;
				}
				GameObject.Find ("PlayerPrototype").GetComponent<PlayerController> ().isQuiz = false;
				QuizTime.SetActive (false);
				yourScore += 10;
			} else {
				//salah
				print("salah");
				GameObject.Find ("PlayerPrototype").GetComponent<PlayerController> ().currentPos -= GameObject.Find ("PlayerPrototype").GetComponent<PlayerController> ().getDadu;
				GameObject.Find ("PlayerPrototype").GetComponent<PlayerController> ().isQuiz = false;
				QuizTime.SetActive (false);
				yourScore -= 5;
			}
		}
		if (ans == 3) {
			if (ans == correct) {
				//benar
				print("benar");
				if (GameObject.Find ("PlayerPrototype").GetComponent<PlayerController> ().isfinal) {
					YouWin.SetActive (true);
				} else {
					GameObject.Find ("PlayerPrototype").GetComponent<PlayerController> ().currentPos += 1;
				}
				GameObject.Find ("PlayerPrototype").GetComponent<PlayerController> ().isQuiz = false;
				QuizTime.SetActive (false);
				yourScore += 10;
			} else {
				//salah
				print("salah");
				GameObject.Find ("PlayerPrototype").GetComponent<PlayerController> ().currentPos -= GameObject.Find ("PlayerPrototype").GetComponent<PlayerController> ().getDadu;
				GameObject.Find ("PlayerPrototype").GetComponent<PlayerController> ().isQuiz = false;
				QuizTime.SetActive (false);
				yourScore -= 5;
			}
		}
		if (ans == 4) {
			if (ans == correct) {
				//benar
				print("benar");
				if (GameObject.Find ("PlayerPrototype").GetComponent<PlayerController> ().isfinal) {
					YouWin.SetActive (true);
				} else {
					GameObject.Find ("PlayerPrototype").GetComponent<PlayerController> ().currentPos += 1;
				}
				GameObject.Find ("PlayerPrototype").GetComponent<PlayerController> ().isQuiz = false;
				QuizTime.SetActive (false);
				yourScore += 10;
			} else {
				//salah
				print("salah");
				GameObject.Find ("PlayerPrototype").GetComponent<PlayerController> ().currentPos -= GameObject.Find ("PlayerPrototype").GetComponent<PlayerController> ().getDadu;
				GameObject.Find ("PlayerPrototype").GetComponent<PlayerController> ().isQuiz = false;
				QuizTime.SetActive (false);
				yourScore -= 5;
			}
		}
	}
}
