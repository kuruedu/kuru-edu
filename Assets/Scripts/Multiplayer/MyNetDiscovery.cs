using UnityEngine;
using System.Collections;
using UnityEngine.Networking;
using UnityEngine.UI;

public class MyNetDiscovery : NetworkDiscovery  {

	void Start(){
		Initialize();
	}

	public void HostGame(){
		Initialize();
		StartAsServer();
	}

	public void joinLan(){
		Initialize();
		StartAsClient();
	}

	public void StopBroad(){
		Initialize();
		StopBroadcast ();
	}

	public override void OnReceivedBroadcast(string fromAddress, string data)
	{
		NetworkManager.singleton.networkAddress = fromAddress;
	}
}
