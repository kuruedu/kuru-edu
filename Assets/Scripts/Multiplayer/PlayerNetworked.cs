using UnityEngine;
using System.Collections;
using UnityEngine.Networking;

public class PlayerNetworked : NetworkBehaviour {

	public GameObject cam;
	public AudioListener aud;
	public GameObject theCanvas;
	public PlayerControlMulti PC;
	public GameObject WaitOther;

	public override void OnStartLocalPlayer ()
	{
		cam.SetActive(true);
		aud.enabled = true;
		theCanvas.SetActive (true);
		PC.enabled = true;
	}

	void Update(){
		if (GameObject.FindGameObjectsWithTag ("Player").Length < 2) {
			WaitOther.SetActive (true);
		} else {
			WaitOther.SetActive (false);
		}
	}
}
