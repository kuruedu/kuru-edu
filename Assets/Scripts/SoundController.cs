using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class SoundController : MonoBehaviour
{

    public Button ButtonMusic;
    public bool suara = true;

    // Use this for initialization
    void Start()
    {
        ButtonMusic.onClick.AddListener(delegate { pergiKeFungsi(1); });
    }

    // Update is called once per frame
    public void pergiKeFungsi(int fungsiId)
    {
        if (fungsiId == 1)
        {
            if (suara == true)
            {
                AudioListener.volume = 0.0f;
                ButtonMusic.GetComponentInChildren<Text>().text = "Music : Off";
                suara = false;
            }
            else {
                AudioListener.volume = 1.0f;
                ButtonMusic.GetComponentInChildren<Text>().text = "Music : On";
                suara = true;
            }
        }
    }
}