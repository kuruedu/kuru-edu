using UnityEngine;
using System.Collections;

public class ScoreController : MonoBehaviour {

	int intScore;
	int intBestScore;
	GooglePlayServices_Access gps;

	// Use this for initialization
	void Start () {
		intBestScore = PlayerPrefs.GetInt ("score");
		gps = this.GetComponent<GooglePlayServices_Access> ();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void addScore(int score){
		intScore += score;

		if (intScore > intBestScore) {
			intBestScore = intScore;
			PlayerPrefs.SetInt ("score", intBestScore);
		}
	}

	void winStatus(int id){
		if(id == 1){
			//menang
		}
		if(id == 2){
			//kalah
		}
		gps.tambahScore (intBestScore);
	}
}