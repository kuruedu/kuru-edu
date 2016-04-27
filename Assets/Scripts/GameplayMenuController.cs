using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameplayMenuController : MonoBehaviour {
	public SoundController SC;
	public GameObject pausePanel;
	public Button pauseButton;
	public Button ResumeButton;
	public Button MenuButton;

	// Use this for initialization
	void Start () {
		SC = GameObject.Find("AudioManager").GetComponent<SoundController>();
		pausePanel.SetActive (false);
		pauseButton.onClick.AddListener (openThePause);
		ResumeButton.onClick.AddListener (closeThePause);
		MenuButton.onClick.AddListener (goToMenu);

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
