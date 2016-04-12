using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameplayMenuController : MonoBehaviour {
	
	public GameObject pausePanel;
	public Button pauseButton;
	public Button ResumeButton;
	public Button MenuButton;

	// Use this for initialization
	void Start () {
		pausePanel.SetActive (false);
		pauseButton.onClick.AddListener (openThePause);
		ResumeButton.onClick.AddListener (closeThePause);
		MenuButton.onClick.AddListener (goToMenu);

	}
	
	public void openThePause(){
		pausePanel.SetActive (true);
	}

	public void closeThePause(){
		pausePanel.SetActive (false);
	}

	public void goToMenu(){
		SceneManager.LoadScene (0);
	}
}
