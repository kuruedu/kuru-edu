using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour {

    //inisialisasi panel
    public GameObject MenuPanel;
    public GameObject PlayPanel;
    public GameObject ProfilePanel;
    public GameObject ScorePanel;
    public GameObject SettingPanel;

	public GooglePlayServices_Access GPSACS;

    //inisialisasi tombol utama
    public Button ButtonPlay;
    public Button ButtonProfile;
    public Button ButtonScore;
    public Button ButtonSetting;
	public Button ButtonExit;
	public Button ButtonAchievement;
	public Button ButtonLogging;
	public Button ButtonSinglePlay;
    public Button[] ButtonBack;
	public Text UserName;

	private bool LoggedOut = false;
	// Use this for initialization
	void Start () {
        MenuPanel.SetActive(true);
        PlayPanel.SetActive(false);
        ProfilePanel.SetActive(false);
        ScorePanel.SetActive(false);
        SettingPanel.SetActive(false);

        ButtonPlay.onClick.AddListener(delegate { pergiKePanel(1); });
        ButtonProfile.onClick.AddListener(delegate { pergiKePanel(2); });
        ButtonScore.onClick.AddListener(delegate { pergiKePanel(3); });
		ButtonSetting.onClick.AddListener(delegate { pergiKePanel(4); });
		ButtonExit.onClick.AddListener(delegate { pergiKePanel(5); });
		ButtonAchievement.onClick.AddListener(delegate { pergiKePanel(6); });
		ButtonLogging.onClick.AddListener(delegate { pergiKePanel(7); });
		ButtonSinglePlay.onClick.AddListener(delegate { pergiKePanel(8); });
        //ButtonBack.onClick.AddListener(delegate { pergiKePanel(0); });
        for (int i = 0; i < ButtonBack.Length; i++) {
            ButtonBack[i].onClick.AddListener(delegate { pergiKePanel(0); });
        }
	}


    public void pergiKePanel(int panelId)
    {
        if (panelId == 0) {
            MenuPanel.SetActive(true);
            PlayPanel.SetActive(false);
            ProfilePanel.SetActive(false);
            ScorePanel.SetActive(false);
            SettingPanel.SetActive(false);
        }
        if (panelId == 1)
        {
            PlayPanel.SetActive(true);
            MenuPanel.SetActive(false);
            ProfilePanel.SetActive(false);
            ScorePanel.SetActive(false);
            SettingPanel.SetActive(false);
        }
        if (panelId == 2)
        {
            ProfilePanel.SetActive(true);
            MenuPanel.SetActive(false);
            PlayPanel.SetActive(false);
            ScorePanel.SetActive(false);
            SettingPanel.SetActive(false);
			UserName.text = GPSACS.UserName;
        }
        if (panelId == 3) {
            /*
			ScorePanel.SetActive(true);
            MenuPanel.SetActive(false);
            PlayPanel.SetActive(false);
            ProfilePanel.SetActive(false);
            SettingPanel.SetActive(false);
            */
			GPSACS.bukaLeaderBoard ();
        }
        if (panelId == 4) {
            SettingPanel.SetActive(true);
            MenuPanel.SetActive(false);
            PlayPanel.SetActive(false);
            ProfilePanel.SetActive(false);
            ScorePanel.SetActive(false);
        }
		if (panelId == 5) {
			Application.Quit ();
		}
		if (panelId == 6) {
			GPSACS.bukaAchievement ();
		}
		if (panelId == 7) {
			if (!LoggedOut) {
				GPSACS.signOut ();
				UserName.text = "Belum Login";
				ButtonLogging.GetComponentInChildren<Text>().text = "Login";
				LoggedOut = true;
			} else {
				GPSACS.Login ();
				UserName.text = GPSACS.UserName;
				ButtonLogging.GetComponentInChildren<Text>().text = "Logout";
				LoggedOut = false;
			}
		}
		if (panelId == 8) {
			SceneManager.LoadScene (1);
		}
    }
}