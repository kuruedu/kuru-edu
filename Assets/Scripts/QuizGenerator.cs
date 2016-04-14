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

		//Soal Matematika
		if (soal == 1) {
			soalNya.text = "2 + 2 =";
			pilA.GetComponentInChildren<Text>().text = "1";
			pilB.GetComponentInChildren<Text>().text = "2";
			pilC.GetComponentInChildren<Text>().text = "3";
			pilD.GetComponentInChildren<Text>().text = "4";

			correct = 4;
		}
		if (soal == 2) {
			soalNya.text = "6 + 9 =";
			pilA.GetComponentInChildren<Text>().text = "15";
			pilB.GetComponentInChildren<Text>().text = "14";
			pilC.GetComponentInChildren<Text>().text = "13";
			pilD.GetComponentInChildren<Text>().text = "12";

			correct = 1;
		}
		if (soal == 3) {
			soalNya.text = "15 + 25 =";
			pilA.GetComponentInChildren<Text>().text = "45";
			pilB.GetComponentInChildren<Text>().text = "40";
			pilC.GetComponentInChildren<Text>().text = "50";
			pilD.GetComponentInChildren<Text>().text = "55";

			correct = 2;
		}
		if (soal == 4) {
			soalNya.text = "78 + 22 =";
			pilA.GetComponentInChildren<Text>().text = "100";
			pilB.GetComponentInChildren<Text>().text = "120";
			pilC.GetComponentInChildren<Text>().text = "330";
			pilD.GetComponentInChildren<Text>().text = "170";

			correct = 1;
		}
		if (soal == 5) {
			soalNya.text = "54 + 15 =";
			pilA.GetComponentInChildren<Text>().text = "66";
			pilB.GetComponentInChildren<Text>().text = "69";
			pilC.GetComponentInChildren<Text>().text = "70";
			pilD.GetComponentInChildren<Text>().text = "90";

			correct = 2;
		}

		//Soal Bahasa Indonesia
		if (soal == 6) {
			soalNya.text = "apa saja unsur 5W + 1H, yaitu... ";
			pilA.GetComponentInChildren<Text>().text = "what, where, who, when, why, how";
			pilB.GetComponentInChildren<Text>().text = "what, wish, world, who, why, hand";
			pilC.GetComponentInChildren<Text>().text = "when, world, week, what, where, how";
			pilD.GetComponentInChildren<Text>().text = "when, what, where, wanna, week, hire";

			correct = 1;
		}
		if (soal == 7) {
			soalNya.text = "manfaat membaca buku adalah";
			pilA.GetComponentInChildren<Text>().text = "sebagai hiburan semata";
			pilB.GetComponentInChildren<Text>().text = "agar dianggap kutu buku";
			pilC.GetComponentInChildren<Text>().text = "menambah wawasan dan pengetahuan";
			pilD.GetComponentInChildren<Text>().text = "supaya tidak dibilang kurang pergaulan";

			correct = 3;
		}
		if (soal == 8) {
			soalNya.text = "Rajin pangkal...";
			pilA.GetComponentInChildren<Text>().text = "Pandai";
			pilB.GetComponentInChildren<Text>().text = "Hebat";
			pilC.GetComponentInChildren<Text>().text = "Kaya";
			pilD.GetComponentInChildren<Text>().text = "Bersih";

			correct = 1;
		}
		if (soal == 9) {
			soalNya.text = "Tong kosong nyaring...";
			pilA.GetComponentInChildren<Text>().text = "Suaranya";
			pilB.GetComponentInChildren<Text>().text = "Teriakannya";
			pilC.GetComponentInChildren<Text>().text = "Bunyinya";
			pilD.GetComponentInChildren<Text>().text = "Lagunya";

			correct = 3;
		}
		if (soal == 10) {
			soalNya.text = "contoh pembukaan dalam pidato adalah";
			pilA.GetComponentInChildren<Text>().text = "selamat pagi teman-teman.";
			pilB.GetComponentInChildren<Text>().text = "cukup sekian dan terimakasih.";
			pilC.GetComponentInChildren<Text>().text = "kita harus menang dalam perlombaan itu.";
			pilD.GetComponentInChildren<Text>().text = "saya minta maaf jika kurang sopan.";

			correct = 1;
		}

		//Soal IPA
		if (soal == 11) {
			soalNya.text = "bebek dapat berenang karena memiliki ciri khusus, yaitu";
			pilA.GetComponentInChildren<Text>().text = "kaki berselaput";
			pilB.GetComponentInChildren<Text>().text = "bernafas menggunakan insang";
			pilC.GetComponentInChildren<Text>().text = "paruh berkantong";
			pilD.GetComponentInChildren<Text>().text = "dapat menyemprotkan tinta";

			correct = 1;
		}
		if (soal == 12) {
			soalNya.text = "unta menyimpan cadangan makanan di punuknya berupa";
			pilA.GetComponentInChildren<Text>().text = "lemak";
			pilB.GetComponentInChildren<Text>().text = "air";
			pilC.GetComponentInChildren<Text>().text = "protein";
			pilD.GetComponentInChildren<Text>().text = "mineral";

			correct = 1;
		}
		if (soal == 13) {
			soalNya.text = "hewan yang melakukan penyamaran sebagai usaha\nmelindungi diri dari kejaran musuhnya, yaitu";
			pilA.GetComponentInChildren<Text>().text = "ular";
			pilB.GetComponentInChildren<Text>().text = "belalang";
			pilC.GetComponentInChildren<Text>().text = "bunglon";
			pilD.GetComponentInChildren<Text>().text = "kura-kura";

			correct = 3;
		}
		if (soal == 14) {
			soalNya.text = "hewan berikut yang termasuk mamalia air adalah";
			pilA.GetComponentInChildren<Text>().text = "kadal dan buaya";
			pilB.GetComponentInChildren<Text>().text = "paus dan pesut";
			pilC.GetComponentInChildren<Text>().text = "ikan tuna dan kura-kura";
			pilD.GetComponentInChildren<Text>().text = "ikan tuna dan lumba-lumba";

			correct = 2;
		}
		if (soal == 15) {
			soalNya.text = "pohon pisang berkembang biak dengan";
			pilA.GetComponentInChildren<Text>().text = "umbi batang";
			pilB.GetComponentInChildren<Text>().text = "umbi lapis";
			pilC.GetComponentInChildren<Text>().text = "tunas";
			pilD.GetComponentInChildren<Text>().text = "geragih";

			correct = 3;
		}

		//Soal IPS
		if (soal == 16) {
			soalNya.text = "Nama mata uang Indonesia adalah";
			pilA.GetComponentInChildren<Text>().text = "Dolar";
			pilB.GetComponentInChildren<Text>().text = "Ringgit";
			pilC.GetComponentInChildren<Text>().text = "Rupiah";
			pilD.GetComponentInChildren<Text>().text = "Rupe";

			correct = 3;
		}
		if (soal == 17) {
			soalNya.text = "Adiknya ayah yang laki-laki kita panggil";
			pilA.GetComponentInChildren<Text>().text = "Bibi";
			pilB.GetComponentInChildren<Text>().text = "Buyut";
			pilC.GetComponentInChildren<Text>().text = "Tante";
			pilD.GetComponentInChildren<Text>().text = "Paman";

			correct = 4;
		}
		if (soal == 18) {
			soalNya.text = "Apa nama tempat untuk pesawat terbang mendarat?";
			pilA.GetComponentInChildren<Text>().text = "Terminal";
			pilB.GetComponentInChildren<Text>().text = "Stasiun";
			pilC.GetComponentInChildren<Text>().text = "Bandara";
			pilD.GetComponentInChildren<Text>().text = "Pelabuhan";

			correct = 3;
		}
		if (soal == 19) {
			soalNya.text = "Kepala keluarga di rumah adalah";
			pilA.GetComponentInChildren<Text>().text = "Ayah";
			pilB.GetComponentInChildren<Text>().text = "Ibu";
			pilC.GetComponentInChildren<Text>().text = "Kakek";
			pilD.GetComponentInChildren<Text>().text = "Nenek";

			correct = 1;
		}
		if (soal == 20) {
			soalNya.text = "Arah antara barat dan utara adalah";
			pilA.GetComponentInChildren<Text>().text = "Timur Laut";
			pilB.GetComponentInChildren<Text>().text = "Tenggara";
			pilC.GetComponentInChildren<Text>().text = "Barat Laut";
			pilD.GetComponentInChildren<Text>().text = "Barat Daya";

			correct = 2;
		}

	}


	// yang answer gua masih gak paham, kok berurutan ya 1234 answernya. padahal di yang lama jawabannya gak ngurut.
	// gausah di edit bang yang ini, cukup edit method GenerateQuiz aja :D *taufiq*
	public void Answering(int ans){
		if (ans == 1) {
			if (ans == correct) {
				//benar
				print("benar");
				if (GameObject.Find ("PlayerPrototype").GetComponent<PlayerController> ().isfinal) {
					YouWin.SetActive (true);
				} else {
					GameObject.Find ("PlayerPrototype").GetComponent<PlayerController> ().moveNextBenarJawab ();
				}
				GameObject.Find ("PlayerPrototype").GetComponent<PlayerController> ().isQuiz = false;
				QuizTime.SetActive (false);
				yourScore += 10;
			} else {
				//salah
				print("salah");
				//GameObject.Find ("PlayerPrototype").GetComponent<PlayerController> ().currentPos -= GameObject.Find ("PlayerPrototype").GetComponent<PlayerController> ().getDadu;
				GameObject.Find ("PlayerPrototype").GetComponent<PlayerController> ().moveBackSalahJawab();
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
					GameObject.Find ("PlayerPrototype").GetComponent<PlayerController> ().moveNextBenarJawab ();
				}
				GameObject.Find ("PlayerPrototype").GetComponent<PlayerController> ().isQuiz = false;
				QuizTime.SetActive (false);
				yourScore += 10;
			} else {
				//salah
				print("salah");
				//GameObject.Find ("PlayerPrototype").GetComponent<PlayerController> ().currentPos -= GameObject.Find ("PlayerPrototype").GetComponent<PlayerController> ().getDadu;
				GameObject.Find ("PlayerPrototype").GetComponent<PlayerController> ().moveBackSalahJawab();
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
					GameObject.Find ("PlayerPrototype").GetComponent<PlayerController> ().moveNextBenarJawab ();
				}
				GameObject.Find ("PlayerPrototype").GetComponent<PlayerController> ().isQuiz = false;
				QuizTime.SetActive (false);
				yourScore += 10;
			} else {
				//salah
				print("salah");
				//GameObject.Find ("PlayerPrototype").GetComponent<PlayerController> ().currentPos -= GameObject.Find ("PlayerPrototype").GetComponent<PlayerController> ().getDadu;
				GameObject.Find ("PlayerPrototype").GetComponent<PlayerController> ().moveBackSalahJawab();
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
					GameObject.Find ("PlayerPrototype").GetComponent<PlayerController> ().moveNextBenarJawab ();
				}
				GameObject.Find ("PlayerPrototype").GetComponent<PlayerController> ().isQuiz = false;
				QuizTime.SetActive (false);
				yourScore += 10;
			} else {
				//salah
				print("salah");
				//GameObject.Find ("PlayerPrototype").GetComponent<PlayerController> ().currentPos -= GameObject.Find ("PlayerPrototype").GetComponent<PlayerController> ().getDadu;
				GameObject.Find ("PlayerPrototype").GetComponent<PlayerController> ().moveBackSalahJawab();
				GameObject.Find ("PlayerPrototype").GetComponent<PlayerController> ().isQuiz = false;
				QuizTime.SetActive (false);
				yourScore -= 5;
			}
		}
	}
}
