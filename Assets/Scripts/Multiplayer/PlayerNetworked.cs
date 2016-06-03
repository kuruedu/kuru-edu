using UnityEngine;
using System.Collections;
using UnityEngine.Networking;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerNetworked : NetworkBehaviour {

	public GameObject cam;
	public AudioListener aud;
	public GameObject theCanvas;
	public PlayerControlMulti PC;
	public GameObject WaitOther;
	public Button batalPermainan;

	public override void OnStartLocalPlayer ()
	{
		cam.SetActive(true);
		aud.enabled = true;
		theCanvas.SetActive (true);
		PC.enabled = true;
		batalPermainan.onClick.AddListener (stopNetworkGame);
	}

	void stopNetworkGame(){
		SceneManager.LoadScene (0);
	}

	void Update(){
		if (GameObject.FindGameObjectsWithTag ("Player").Length < 2) {
			WaitOther.SetActive (true);
		} else {
			WaitOther.SetActive (false);
		}
	}
}
