﻿using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour
{
	public SoundController SC;

    //inisialisasi panel
    public GameObject MenuPanel;
    public GameObject PlayPanel;
    public GameObject ProfilePanel;
    public GameObject ScorePanel;
    public GameObject SettingPanel;
    public GameObject CreditsPanel;

	public CreditsNew CreditScript;
	public RawImage ProfPic;

	public int myScore;

    public GooglePlayServices_Access GPSACS;

    //inisialisasi tombol utama
    public Button ButtonPlay;
    public Button ButtonProfile;
    public Button ButtonScore;
    public Button ButtonSetting;
    public Button ButtonCredits;
    public Button ButtonExit;
    public Button ButtonAchievement;
    public Button ButtonLogging;
    public Button ButtonSinglePlay;
    public Button[] ButtonBack;
    public Text UserName;
	public Text UserID;
	public Text theScore;

    private bool LoggedOut = false;
    // Use this for initialization+
    void Start()
    {
        MenuPanel.SetActive(true);
        PlayPanel.SetActive(false);
        ProfilePanel.SetActive(false);
        ScorePanel.SetActive(false);
        SettingPanel.SetActive(false);
		SC = GameObject.Find ("AudioManager").GetComponent<SoundController> ();

		myScore =  PlayerPrefs.GetInt ("score");

        ButtonPlay.onClick.AddListener(delegate { pergiKePanel(1); });
        ButtonProfile.onClick.AddListener(delegate { pergiKePanel(2); });
        ButtonScore.onClick.AddListener(delegate { pergiKePanel(3); });
        ButtonSetting.onClick.AddListener(delegate { pergiKePanel(4); });
        ButtonExit.onClick.AddListener(delegate { pergiKePanel(5); });
        ButtonAchievement.onClick.AddListener(delegate { pergiKePanel(6); });
        ButtonLogging.onClick.AddListener(delegate { pergiKePanel(7); });
        ButtonSinglePlay.onClick.AddListener(delegate { pergiKePanel(8); });
        ButtonCredits.onClick.AddListener(delegate { pergiKePanel(9); });
        //ButtonBack.onClick.AddListener(delegate { pergiKePanel(0); });
        for (int i = 0; i < ButtonBack.Length; i++)
        {
            ButtonBack[i].onClick.AddListener(delegate { pergiKePanel(0); });
        }
    }


    public void pergiKePanel(int panelId)
    {
		GameObject.FindObjectOfType<AdMobController> ().tampilkanBanner ();
		SC.playSFX (0);
        if (panelId == 0)
        {
            MenuPanel.SetActive(true);
            PlayPanel.SetActive(false);
            ProfilePanel.SetActive(false);
            ScorePanel.SetActive(false);
            SettingPanel.SetActive(false);
            CreditsPanel.SetActive(false);
        }
        if (panelId == 1)
        {
            PlayPanel.SetActive(true);
            MenuPanel.SetActive(false);
            ProfilePanel.SetActive(false);
            ScorePanel.SetActive(false);
            SettingPanel.SetActive(false);
            CreditsPanel.SetActive(false);
        }
        if (panelId == 2)
        {
            ProfilePanel.SetActive(true);
            MenuPanel.SetActive(false);
            PlayPanel.SetActive(false);
            ScorePanel.SetActive(false);
            SettingPanel.SetActive(false);
			/*
			if (UserID.text.Equals (null)) {
				UserName.text = GPSACS.UserName;
				UserID.text = GPSACS.UserID;
				//ProfPic.texture = GPSACS.UserPic;
			}
			*/
			UserName.text = PlayerPrefs.GetString ("name");
			theScore.text = "HighScore " + myScore + "\n Menang : " + PlayerPrefs.GetInt("win") + " / Kalah :" + PlayerPrefs.GetInt("lose");
            CreditsPanel.SetActive(false);
        }
        if (panelId == 3)
        {
            /*
			ScorePanel.SetActive(true);
            MenuPanel.SetActive(false);
            PlayPanel.SetActive(false);
            ProfilePanel.SetActive(false);
            SettingPanel.SetActive(false);
            */
			int intBestScore = PlayerPrefs.GetInt ("score");
			GameObject.FindObjectOfType<GooglePlayServices_Access> ().tambahScore (intBestScore);
            GPSACS.bukaLeaderBoard();
        }
        if (panelId == 4)
        {
            SettingPanel.SetActive(true);
            MenuPanel.SetActive(false);
            PlayPanel.SetActive(false);
            ProfilePanel.SetActive(false);
            ScorePanel.SetActive(false);
            CreditsPanel.SetActive(false);
        }
        if (panelId == 5)
        {
            Application.Quit();
        }
        if (panelId == 6)
        {
            GPSACS.bukaAchievement();
        }
        if (panelId == 7)
        {
            if (!LoggedOut)
            {
                GPSACS.signOut();
                UserName.text = "Belum Login";
                ButtonLogging.GetComponentInChildren<Text>().text = "Login";
                LoggedOut = true;
            }
            else {
                GPSACS.Login();
                UserName.text = GPSACS.UserName;
                ButtonLogging.GetComponentInChildren<Text>().text = "Logout";
                LoggedOut = false;
            }
        }
        if (panelId == 8)
        {
            SceneManager.LoadScene(1);
        }
        if (panelId == 9)
        {
			CreditScript.roll = true;
            CreditsPanel.SetActive(true);
            SettingPanel.SetActive(false);
            MenuPanel.SetActive(false);
            PlayPanel.SetActive(false);
            ProfilePanel.SetActive(false);
            ScorePanel.SetActive(false);
        }
    }
}