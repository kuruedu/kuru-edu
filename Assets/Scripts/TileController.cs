using UnityEngine;
using System.Collections;

public class TileController : MonoBehaviour {

	public GameObject QuizGuru;
	public GameObject Teleport;
	public GameObject[] Tiles; //hanya untuk menyimpan GO Tiles

	public int[] QuizZoneNum;
	public int[] TeleZoneNum;

	void Start(){
		RandomQuizZone ();
		SpawnQuizGuru ();
		RandomTeleZone ();
		SpawnTeleport ();
	}

	public void RandomTeleZone(){
		TeleZoneNum [0] = Random.Range (1, 21);
		TeleZoneNum [1] = Random.Range (21, 41);
		TeleZoneNum [2] = Random.Range (41, 61);
		TeleZoneNum [3] = Random.Range (61, 81);
		TeleZoneNum [4] = Random.Range (81, 101);

		for (int i = 0; i < QuizZoneNum.Length; i++) {
			if (TeleZoneNum [0] == QuizZoneNum [i]) {
				TeleZoneNum [0] += 1;
			}
		}

		for (int i = 0; i < QuizZoneNum.Length; i++) {
			if (TeleZoneNum [1] == QuizZoneNum [i]) {
				TeleZoneNum [1] += 1;
			}
		}

		for (int i = 0; i < QuizZoneNum.Length; i++) {
			if (TeleZoneNum [2] == QuizZoneNum [i]) {
				TeleZoneNum [2] += 1;
			}
		}

		for (int i = 0; i < QuizZoneNum.Length; i++) {
			if (TeleZoneNum [3] == QuizZoneNum [i]) {
				TeleZoneNum [3] += 1;
			}
		}

		for (int i = 0; i < QuizZoneNum.Length; i++) {
			if (TeleZoneNum [4] == QuizZoneNum [i]) {
				TeleZoneNum [4] += 1;
			}
		}
	}

	public void RandomQuizZone(){
		QuizZoneNum [0] = Random.Range (1, 11);
		QuizZoneNum [1] = Random.Range (11, 21);
		QuizZoneNum [2] = Random.Range (21, 31);
		QuizZoneNum [3] = Random.Range (31, 41);
		QuizZoneNum [4] = Random.Range (41, 51);
		QuizZoneNum [5] = Random.Range (51, 61);
		QuizZoneNum [6] = Random.Range (61, 71);
		QuizZoneNum [7] = Random.Range (71, 81);
		QuizZoneNum [8] = Random.Range (81, 91);
		QuizZoneNum [9] = Random.Range (91, 101);
	}

	public void SpawnQuizGuru(){
		for(int i = 0; i<QuizZoneNum.Length; i++){
			Instantiate (QuizGuru, Tiles [QuizZoneNum [i]].transform.position, Tiles [QuizZoneNum [i]].transform.rotation);
		}
	
	}

	public void SpawnTeleport(){
		for(int i = 0; i<TeleZoneNum.Length; i++){
			Instantiate (Teleport, Tiles [TeleZoneNum [i]].transform.position, Tiles [TeleZoneNum [i]].transform.rotation);
		}

	}

}
