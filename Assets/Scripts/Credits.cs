using UnityEngine;

public class Credits : MonoBehaviour
{
    //inisialisasi panel
    public GameObject MenuPanel;
    public GameObject PlayPanel;
    public GameObject ProfilePanel;
    public GameObject ScorePanel;
    public GameObject SettingPanel;
    public GameObject CreditsPanel;

    private float offset;
    public float speed = 29.0f;
    public GUIStyle style;
    public Rect viewArea;



    private void Start()
    {
        if (this.viewArea.width == 0.0f)
        {
            this.viewArea = new Rect(0.0f, 0.0f, Screen.width, Screen.height);
        }
        this.offset = this.viewArea.height;
    }

    private void Update()
    {
        this.offset -= Time.deltaTime * this.speed;
    }

    private void OnGUI()
    {
        GUI.BeginGroup(this.viewArea);

        var position = new Rect(0, this.offset, this.viewArea.width, this.viewArea.height);
        var text = @" Kuru Team : 

Taufiq Abdullah
(Programmer)

Abdul Rozak Chaidir
(Analyst)

Muhammad Yusuf M
(Programmer)

Rini Anggoro Wati
(Designer)

Zahra Qurota Aini
(Designer, Quiz Making)";

        GUI.Label(position, text, this.style);

        GUI.EndGroup();

    }

    /**private void fungsiBack()
    {
        SettingPanel.SetActive(true);
        MenuPanel.SetActive(false);
        PlayPanel.SetActive(false);
        ProfilePanel.SetActive(false);
        ScorePanel.SetActive(false);
        CreditsPanel.SetActive(false);
    }**/
}