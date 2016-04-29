using UnityEngine;
using System.Collections;

public class ScoreController : MonoBehaviour {

	public int intScore;
	public int intBestScore;
	//GooglePlayServices_Access gps;

	// Use this for initialization
	void Start () {
		intBestScore = PlayerPrefs.GetInt ("score");
		//gps = this.GetComponent<GooglePlayServices_Access> ();
	}

	public void addScore(int score){
		intScore += score;
	}

	public void winStatus(int id){
		if(id == 1){
			//menang
		}
		if(id == 2){
			//kalah
		}
		if (intScore > intBestScore) {
			intBestScore = intScore;
			PlayerPrefs.SetInt ("score", intBestScore);
		}
		//gps.tambahScore (intBestScore);
		GameObject.FindObjectOfType<GooglePlayServices_Access> ().tambahScore (intBestScore);
	}
}