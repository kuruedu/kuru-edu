using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class SoundController : MonoBehaviour
{

    //private Button ButtonMusic;
	//private Button ButtonSfx;
    public bool suara = true;
	public bool sfx = true;

    public AudioClip[] soundFX;
	public AudioClip[] soundBGM;
	public AudioSource suarabgm;
	public AudioSource suarasfx;

    // Use this for initialization
    void Start()
    {
		GameObject.Find("References").GetComponent<References>().buttonBGM.onClick.AddListener(delegate { pergiKeFungsi(1); });
		GameObject.Find("References").GetComponent<References>().buttonSFX.onClick.AddListener(delegate { pergiKeFungsi(2); });
		//suarabgm.PlayOneShot(soundBGM[0]);
		suarabgm.clip = soundBGM [0];
		suarabgm.Play ();
    }

	void OnLevelWasLoaded(int level){
		if (level == 0) { //menu
			suarabgm.Stop();
			suarabgm.clip = soundBGM [level];
			suarabgm.Play ();

			GameObject.Find("References").GetComponent<References>().buttonBGM.onClick.AddListener(delegate { pergiKeFungsi(1); });
			GameObject.Find("References").GetComponent<References>().buttonSFX.onClick.AddListener(delegate { pergiKeFungsi(2); });

		}
		if (level == 1) { //game
			suarabgm.Stop();
			suarabgm.clip = soundBGM [level];
			suarabgm.Play ();
		}
	}

    public void playSFX(int id)
    {
        if(id == 0)
        {
			suarasfx.PlayOneShot(soundFX[id]);		//suara buttons
        }
		if (id == 1) 
		{
			suarasfx.PlayOneShot (soundFX [id]);		//suara surprise
		}
		if (id == 2) 
		{
			suarasfx.PlayOneShot (soundFX [id]);		//suara footstep
		}
		if (id == 3) 
		{
			suarasfx.PlayOneShot (soundFX [id]);		//suara rolling dice
		}
		if (id == 4) 
		{
			suarasfx.PlayOneShot (soundFX [id]);		//suara winquiz
		}
		if (id == 5) 
		{
			suarasfx.PlayOneShot (soundFX [id]);		//suara winquiz
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
				GameObject.Find("References").GetComponent<References>().buttonBGM.GetComponentInChildren<Text>().text = "Music : Off";
                suara = false;
            }
            else {
				suarabgm.volume = 0.5f;
				GameObject.Find("References").GetComponent<References>().buttonBGM.GetComponentInChildren<Text>().text = "Music : On";
                suara = true;
            }
        }

		if (fungsiId == 2)
		{
			if (sfx == true)
			{
				suarasfx.volume = 0.0f;
				GameObject.Find("References").GetComponent<References>().buttonSFX.GetComponentInChildren<Text>().text = "Sfx : Off";
				sfx = false;
			}
			else {
				suarasfx.volume = 1.0f;
				GameObject.Find("References").GetComponent<References>().buttonSFX.GetComponentInChildren<Text>().text = "Sfx : On";
				sfx = true;
			}
		}
    }
}