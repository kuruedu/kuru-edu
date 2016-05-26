using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class TeleportControllerMulti : MonoBehaviour {

	public GameObject TeleportMenu;
	public Button AcakBut;
	public Text Angka;
	private int kotak;

	// Use this for initialization
	void Start () {
		TeleportMenu.SetActive (false);
		AcakBut.onClick.AddListener (ButtonAcak);
	}

	public void openTeleportMenu(){
		TeleportMenu.SetActive (true);
	}

	public void ButtonAcak(){
		kotak = Random.Range (1, 101);
		Angka.text = "" + kotak;
		StartCoroutine (closePanel ());
	}

	IEnumerator closePanel(){
		yield return new WaitForSeconds (1f);
		GameObject.FindObjectOfType<ScoreController> ().addScore (10);
		TeleportMenu.SetActive (false);
		this.GetComponent<PlayerNetworked> ().PC.currentPos = kotak;
		this.GetComponent<PlayerNetworked> ().PC.finalPos = kotak;
		this.GetComponent<PlayerNetworked> ().PC.isTeleport = false;
		Angka.text = "0";
	}
}
