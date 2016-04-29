using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameplayMenuController : MonoBehaviour {
	public SoundController SC;
	public GameObject pausePanel;
	public Button showHideNum;
	public Button pauseButton;
	public Button ResumeButton;
	public Button MenuButton;
	public GameObject NumTiles;

	public bool numShow = true;

	// Use this for initialization
	void Start () {
		SC = GameObject.Find("AudioManager").GetComponent<SoundController>();
		pausePanel.SetActive (false);
		pauseButton.onClick.AddListener (openThePause);
		ResumeButton.onClick.AddListener (closeThePause);
		MenuButton.onClick.AddListener (goToMenu);
		showHideNum.onClick.AddListener (ShowHideNumber);

	}

	public void ShowHideNumber(){
		if (numShow) {
			showHideNum.GetComponentInChildren<Text> ().text = "x_x";
			NumTiles.SetActive (false);
			numShow = false;
		} else {
			showHideNum.GetComponentInChildren<Text> ().text = "0_0";
			NumTiles.SetActive (true);
			numShow = true;
		}
		SC.playSFX (0);
		GameObject.FindObjectOfType<GooglePlayServices_Access> ().UnlockAchievement (4);
	}
	
	public void openThePause(){
		SC.playSFX (0);
		pausePanel.SetActive (true);
	}

	public void closeThePause(){
		SC.playSFX (0);
		pausePanel.SetActive (false);
	}

	public void goToMenu(){
		SC.playSFX (0);
		SceneManager.LoadScene (0);
	}
}
