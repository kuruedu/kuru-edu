using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

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
			int addwin = PlayerPrefs.GetInt("win") + 1;
			PlayerPrefs.SetInt("win",addwin);
			StartCoroutine (loadMainMenu ());
		}
		if(id == 2){
			//kalah
			int addlose = PlayerPrefs.GetInt("lose") + 1;
			PlayerPrefs.SetInt("lose",addlose);
			StartCoroutine (loadMainMenu ());
		}
		if (intScore > intBestScore) {
			intBestScore = intScore;
			PlayerPrefs.SetInt ("score", intBestScore);
		}
		GameObject.FindObjectOfType<AdMobController>().requestIklan();
		GameObject.FindObjectOfType<AdMobController> ().tampilkanInterstitial ();
		GameObject.FindObjectOfType<GooglePlayServices_Access> ().tambahScore (intScore);
	}

	IEnumerator loadMainMenu(){
		yield return new WaitForSeconds (2);
		SceneManager.LoadScene (0);
	}
}