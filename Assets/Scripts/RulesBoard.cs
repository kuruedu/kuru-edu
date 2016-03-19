using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class RulesBoard : MonoBehaviour {

	public GameObject[] zone; //variable zone untuk zona, bertipe array
	public int curZone = 0; //inisialisasi current zone menjadi 0
	public int dice; //variable untuk menyimpan mata dadu
	public bool turn = false; //variable boolean untuk menentukan giliran
	public GameObject Player; //gameobject playernya
	public Text diceNum; // text untuk menampilkan mata dadu yg keluar
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if(turn){ //ketika mendapat giliran
			Player.transform.position = zone [curZone].transform.position; // pindahkan posisi player ke posisi yg seharusnya sesuai current zone yang dipengaruhi mata dadu
			turn = false; //mengembalikan giliran menjadi false
		}

		diceNum.text = "Dice : " + dice; // menampilkan jumlah mata dadu

	}

	public void rollDice(){ //method rollDice yang dipanggil oleh tombol rollDice
		Debug.Log ("Clicked"); //untuk debbugging
		dice = Random.Range (1, 7); //menghasilkan angka acak dari 1 sampai 6 dan disimpan ke variable dice
		turn = true; //menjadikan giliran true
		curZone += dice; //manipulasi current zone ditambah dengan jumlah dadu
	}


}

//Code by Taufiq Abdullah