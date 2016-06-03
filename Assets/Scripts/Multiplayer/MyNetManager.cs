using UnityEngine;
using System.Collections;
using UnityEngine.Networking;
using UnityEngine.UI;

public class MyNetManager : NetworkManager
{
	public MyNetDiscovery dis;
	public bool imServer = false;

	public Button HostGames;
	//public Button JoinGames;
	//public Button Disconnect;
	public Button RefreshServer;
	public Text RefreshText;
	//public Text numPlayer;
	public Text ServIP;

	//public GameObject MenuGameNya;

	//public GameObject[] BaseButton;

	void Start(){
		HostGames.onClick.RemoveAllListeners ();
		HostGames.onClick.AddListener (StartupHost);

		//JoinGames.onClick.RemoveAllListeners ();
		//JoinGames.onClick.AddListener (JoinGame);

		RefreshServer.onClick.RemoveAllListeners ();
		RefreshServer.onClick.AddListener (RefreJo);

		//Disconnect.onClick.RemoveAllListeners ();
		//Disconnect.onClick.AddListener (DisconnectGame);

		//DCButton (false);
		NetworkManager.singleton.networkAddress = null;
	}

	public void StartupHost(){
		dis.HostGame ();
		NetworkManager.singleton.networkPort = 7777;
		NetworkManager.singleton.StartHost ();
		imServer = true;
		//DCButton (true);

	}

	public void JoinGame (){
		if (NetworkManager.singleton.networkAddress != null) {
			NetworkManager.singleton.networkPort = 7777;
			NetworkManager.singleton.StartClient ();
			imServer = false;
			//DCButton (true);
		}
	}

	public void Refresh(){
		NetworkManager.singleton.networkAddress = null;
		dis.joinLan ();
	}

	public void RefreJo(){
		if (NetworkManager.singleton.networkAddress == null) {
			Refresh ();
		} else {
			JoinGame ();
		}
	}

	public void DisconnectGame(){
		if (imServer) {
			NetworkManager.singleton.StopHost ();
			dis.StopBroad ();
		} else {
			NetworkManager.singleton.StopClient ();
		}
		//DCButton (false);
	}
	/*
	public void DCButton(bool status){
		if (!status) {
			BaseButton [0].SetActive (true);
			BaseButton [1].SetActive (true);
			BaseButton [2].SetActive (false);
			BaseButton [3].SetActive (true);
		} else {
			BaseButton [0].SetActive (false);
			BaseButton [1].SetActive (false);
			BaseButton [2].SetActive (true);
			BaseButton [3].SetActive (false);
		}
	}

	*/
	void OnLevelWasLoaded(int level){
		if (level == 0) {
			HostGames = GameObject.FindObjectOfType<MenuController>().HostGames;
			RefreshServer = GameObject.FindObjectOfType<MenuController>().RefreshServer;
			RefreshText = GameObject.FindObjectOfType<MenuController>().RefreshText;
			ServIP = GameObject.FindObjectOfType<MenuController>().ServIP;

			HostGames.onClick.RemoveAllListeners ();
			HostGames.onClick.AddListener (StartupHost);

			//JoinGames.onClick.RemoveAllListeners ();
			//JoinGames.onClick.AddListener (JoinGame);

			RefreshServer.onClick.RemoveAllListeners ();
			RefreshServer.onClick.AddListener (RefreJo);

			//Disconnect.onClick.RemoveAllListeners ();
			//Disconnect.onClick.AddListener (DisconnectGame);

			//DCButton (false);
			NetworkManager.singleton.networkAddress = null;

			DisconnectGame ();
			print ("level 1 laoded");
		} else {
			
			print ("level ex laoded");
		}
	}

	void Update(){
		//	numPlayer.text = "Player :" +(int)GameObject.FindGameObjectsWithTag ("Player").Length;
		if (NetworkManager.singleton.networkAddress == null) {
			ServIP.text = "Press Refresh !!!";
			RefreshText.text = "Cari";
			//RefreshServer.onClick.AddListener (Refresh);
		} else {
			ServIP.text = "IP : " + NetworkManager.singleton.networkAddress;
			RefreshText.text = "Gabung";
			//RefreshServer.onClick.AddListener (JoinGame);
		}
	}
}
