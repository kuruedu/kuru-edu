using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class SoundController : MonoBehaviour
{

    public Button ButtonMusic;
	public Button ButtonSfx;
    public bool suara = true;
	public bool sfx = true;

    public AudioClip[] soundFX;
	public AudioSource suarabgm;
	public AudioSource suarasfx;

    // Use this for initialization
    void Start()
    {
		suarasfx = GetComponent<AudioSource>();
        ButtonMusic.onClick.AddListener(delegate { pergiKeFungsi(1); });
		ButtonSfx.onClick.AddListener(delegate { pergiKeFungsi(2); });
    }

    public void playSFX(int id)
    {
        if(id == 1)
        {
			GameObject.Find("Audio Source").GetComponent<AudioSource>().PlayOneShot(soundFX[0]);		//suara jalan
        }
		if (id == 2) 
		{
			GameObject.Find ("Audio Source").GetComponent<AudioSource>().PlayOneShot (soundFX [1]);		//suara surprise
		}
    }

    // Update is called once per frame
    public void pergiKeFungsi(int fungsiId)
    {
        if (fungsiId == 1)
        {
            if (suara == true)
            {
				suarabgm.volume = 0.0f;
                ButtonMusic.GetComponentInChildren<Text>().text = "Music : Off";
                suara = false;
            }
            else {
				suarabgm.volume = 1.0f;
                ButtonMusic.GetComponentInChildren<Text>().text = "Music : On";
                suara = true;
            }
        }

		if (fungsiId == 2)
		{
			if (sfx == true)
			{
				suarasfx.volume = 0.0f;
				ButtonSfx.GetComponentInChildren<Text>().text = "Sfx : Off";
				sfx = false;
			}
			else {
				suarasfx.volume = 1.0f;
				ButtonSfx.GetComponentInChildren<Text>().text = "Sfx : On";
				sfx = true;
			}
		}
    }
}