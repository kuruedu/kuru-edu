using UnityEngine;
using System.Collections;
using GooglePlayGames;
using UnityEngine.SocialPlatforms;
//using UnityEngine.UI;

public class GooglePlayServices_Access : MonoBehaviour {

	private string leaderboard = "CgkI_fbZn90HEAIQAg"; //LeaderBoardnya dari Play Store

	//Variable String yang menyimpan ID Achievement dari google play Services
	private string achievement_selamatDatang = "CgkI_fbZn90HEAIQAQ";
	private string achievement_menjawabBenar = "CgkI_fbZn90HEAIQBA";
	private string achievement_menjawabSalah = "CgkI_fbZn90HEAIQBQ";
	private string achievement_menang = "CgkI_fbZn90HEAIQBg";
	private string achievement_hilangkanAngka = "CgkI_fbZn90HEAIQBw";

	public string UserName;
	public string UserID;
	public Texture2D UserPic;
	//public string ProfilePic;




	// Use this for initialization
	void Start () { //ketika program pertamakali berjalan
		PlayGamesPlatform.Activate(); //mengaktifkan Plugin PlayGamesPlatforms (Google Play Services)
		LoginGoogle (); //memanggil Method Login, maka saat applikasi berjalan maka user otomatis login / memilih Account Email yg tersedia pada Android nya
	}

	public void getPlayerDetail(){
		UserName  = Social.localUser.userName; // UserName
		UserID      = Social.localUser.id; // UserID
		UserPic = Social.localUser.image;
		//ProfPic.GetComponent<Image>().sprite    =Social.localUser.image; // ProfilePic
	}

	//Method Login ke Google Play
	public void LoginGoogle(){
		Social.localUser.Authenticate((bool success) => //memanggil method khusus yang disediakan oleh API Google Play Services untuk Login
			{
				if (success) //jika sukses
				{
					Debug.Log("You've successfully logged in"); //cetak kalimat untuk debugging
					getPlayerDetail();
				}
				else //jika gagal
				{
					Debug.Log("Login failed for some reason"); //cetak kalimat untuk debugging
				}
			});
	}
		

	//method untuk unlock Achievement
	public void UnlockAchievement(int id){ //memiliki parameter "id" untuk membedakan achievement yang akan di Unlock
		if (Social.localUser.authenticated) //jika sudah login
		{
			if (id == 1) { 
				Social.ReportProgress(achievement_selamatDatang, 100.0f, (bool success) => //unlock achievement selamat belajar sebanyak 100%
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
			if (id == 2) { 
				Social.ReportProgress(achievement_menjawabBenar, 100.0f, (bool success) => //unlock achievement selamat belajar sebanyak 100%
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
			if (id == 3) { 
				Social.ReportProgress(achievement_menjawabSalah, 100.0f, (bool success) => //unlock achievement selamat belajar sebanyak 100%
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
			if (id == 4) { 
				Social.ReportProgress(achievement_hilangkanAngka, 100.0f, (bool success) => //unlock achievement selamat belajar sebanyak 100%
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
			if (id == 5) { 
				Social.ReportProgress(achievement_menang, 100.0f, (bool success) => //unlock achievement selamat belajar sebanyak 100%
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
		

	//method membuka LeaderBoard
	public void bukaLeaderBoard(){
		((PlayGamesPlatform)Social.Active).ShowLeaderboardUI(leaderboard); //memanggil method ShowLeaderBoard(id leaderboard) dan menampilkannya pada activity
		Debug.Log("leadercalled");
	}

	//method membuka achievement
	public void bukaAchievement(){
		Social.ShowAchievementsUI(); //menampilkan activity achievement yang sudah kita raih
	}

	//method signout
	public void signOut(){
		((PlayGamesPlatform)Social.Active).SignOut(); //melakukan proses signout dari account Google yang sedang aktif
	}

	public void Login(){
		LoginGoogle (); //memanggil Method Login, maka saat applikasi berjalan maka user otomatis login / memilih Account Email yg tersedia pada Android nya
	}

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


}

