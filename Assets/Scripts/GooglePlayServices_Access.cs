using UnityEngine;
using System.Collections;
using GooglePlayGames;
using UnityEngine.SocialPlatforms;

public class GooglePlayServices_Access : MonoBehaviour {



	//private string leaderboard = "CgkIlqDbgLoJEAIQBQ"; //variable yang menyimpan id Leaderboard HijaiyahKu dari Google Play Services

	//Variable String yang menyimpan ID Achievement dari google play Services
	//private string achievement_selamatBelajar = "CgkIlqDbgLoJEAIQAQ";
	//private string achievement_jagoHijaiah = "CgkIlqDbgLoJEAIQAg";
	//private string achievement_hebatHijaiah = "CgkIlqDbgLoJEAIQAw";
	//private string achievement_ingatan_Bagus = "CgkIlqDbgLoJEAIQBA";

	public void Awake(){ //saat program berjalan
		DontDestroyOnLoad(this); //jangan hancurkan gameObject ini (GGPs) game object yg mengandung script ini, dengan demikian, GameObject ini mampu berpindah" dari satu scene ke scene lainnya tanpa kehilangan attribut data

		if (FindObjectsOfType(GetType()).Length > 1) //mencari apabila ada duplikasi object GGPs
		{
			Destroy(gameObject); //bila ada, maka hancurkan / hapus Object duplikatnya
		}
	}

	// Use this for initialization
	void Start () { //ketika program pertamakali berjalan
		PlayGamesPlatform.Activate(); //mengaktifkan Plugin PlayGamesPlatforms (Google Play Services)
		LoginGoogle (); //memanggil Method Login, maka saat applikasi berjalan maka user otomatis login / memilih Account Email yg tersedia pada Android nya
	}

	//Method Login ke Google Play
	public void LoginGoogle(){
		Social.localUser.Authenticate((bool success) => //memanggil method khusus yang disediakan oleh API Google Play Services untuk Login
			{
				if (success) //jika sukses
				{
					Debug.Log("You've successfully logged in"); //cetak kalimat untuk debugging
				}
				else //jika gagal
				{
					Debug.Log("Login failed for some reason"); //cetak kalimat untuk debugging
				}
			});
	}
		
	/*
	//method untuk unlock Achievement
	public void UnlockAchievement(int id){ //memiliki parameter "id" untuk membedakan achievement yang akan di Unlock
		if (Social.localUser.authenticated) //jika sudah login
		{
			if (id == 1) { //jika id = 1 maka 
				Social.ReportProgress(achievement_selamatBelajar, 100.0f, (bool success) => //unlock achievement selamat belajar sebanyak 100%
				{
					if (success)
					{
						Debug.Log("Added");
					}
					else
					{
						Debug.Log("Fail");
					}
				});
			}
			if (id == 2) { //jika id = 2 maka 
				Social.ReportProgress(achievement_jagoHijaiah, 100.0f, (bool success) => //unlock achievement jago hijaiah sebanyak 100%
					{
						if (success)
						{
							Debug.Log("Added");
						}
						else
						{
							Debug.Log("Fail");
						}
					});
			}
			if (id == 3) { //jika id = 3 maka
				Social.ReportProgress(achievement_hebatHijaiah, 100.0f, (bool success) => //unlock achievement hebat hijaiyah sebanyak 100%
					{
						if (success)
						{
							Debug.Log("Added");
						}
						else
						{
							Debug.Log("Fail");
						}
					});
			}
			if (id == 4) { //jika id = 4 maka
				Social.ReportProgress(achievement_ingatan_Bagus, 100.0f, (bool success) => //unlock achievement ingatan bagus sebanyak 100%
					{
						if (success)
						{
							Debug.Log("Added");
						}
						else
						{
							Debug.Log("Fail");
						}
					});
			}
		}
	}
		*/
	/*
	//method membuka LeaderBoard
	public void bukaLeaderBoard(){
		((PlayGamesPlatform)Social.Active).ShowLeaderboardUI(leaderboard); //memanggil method ShowLeaderBoard(id leaderboard) dan menampilkannya pada activity
	}
	*/
	//method membuka achievement
	public void bukaAchievement(){
		Social.ShowAchievementsUI(); //menampilkan activity achievement yang sudah kita raih
	}

	//method signout
	public void signOut(){
		((PlayGamesPlatform)Social.Active).SignOut(); //melakukan proses signout dari account Google yang sedang aktif
	}
	/*
	//method tambah score untuk ditampilkan di leaderboard
	public void tambahScore(int score){ //memiliki parameter int score untuk memasukan score secara spesifik
		if (Social.localUser.authenticated) //jika sudah login
		{
			Social.ReportScore(score, leaderboard, (bool success) => //post sejumlah score sesuai value pada parameter dan simpan ke leaderboard
				{
					if (success)
					{
						Debug.Log("Added");
					}
					else
					{
						Debug.Log("Fail");
					}
				});
		}

	}
	*/

}

