using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class MenuController : MonoBehaviour {

	//ini panel
	public GameObject MenuPanel;
	public GameObject ProfilePanel;
	public GameObject SettingPanel;

	//ini button
	public Button ButtonProfile;
	public Button ButtonSetting;
	public Button[] ButtonBack; 


	// Use this for initialization
	void Start () {
		MenuPanel.SetActive (true);
		ProfilePanel.SetActive (false);

		ButtonProfile.onClick.AddListener ( delegate { pergiKePanel(1); } );
		ButtonSetting.onClick.AddListener (delegate { pergiKePanel(2); } );
		ButtonBack[0].onClick.AddListener ( delegate { pergiKePanel (0); } );
		ButtonBack[1].onClick.AddListener ( delegate { pergiKePanel (0); } );
	}

	public void pergiKePanel(int panelId){
		//id 0 = menu
		//id 1 = profile
		//id 2 = setting
		if (panelId == 0) { //go to menu
			MenuPanel.SetActive (true); 
			ProfilePanel.SetActive (false);
			SettingPanel.SetActive (false);
		}

		if (panelId == 1) { //go to profile
			MenuPanel.SetActive (false);
			ProfilePanel.SetActive (true);
			SettingPanel.SetActive (false);
		}

		if (panelId == 2) {
			MenuPanel.SetActive (false);
			ProfilePanel.SetActive (false);
			SettingPanel.SetActive (true);
		}
	}
	

}
