using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class MenuController : MonoBehaviour {

    //inisialisasi panel
    public GameObject MenuPanel;
    public GameObject PlayPanel;
    public GameObject ProfilePanel;
    public GameObject ScorePanel;
    public GameObject SettingPanel;

    //inisialisasi tombol
    public Button ButtonPlay;
    public Button ButtonProfile;
    public Button ButtonScore;
    public Button ButtonSetting;
    public Button[] ButtonBack;

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
        }
        if (panelId == 3) {
            ScorePanel.SetActive(true);
            MenuPanel.SetActive(false);
            PlayPanel.SetActive(false);
            ProfilePanel.SetActive(false);
            SettingPanel.SetActive(false);
        }
        if (panelId == 4) {
            SettingPanel.SetActive(true);
            MenuPanel.SetActive(false);
            PlayPanel.SetActive(false);
            ProfilePanel.SetActive(false);
            ScorePanel.SetActive(false);
        }
    }
}