using UnityEngine;
using System.Collections;

public class ImortalOBJ : MonoBehaviour {

	public void Awake(){ //saat program berjalan
		DontDestroyOnLoad(this); //jangan hancurkan gameObject ini (GGPs) game object yg mengandung script ini, dengan demikian, GameObject ini mampu berpindah" dari satu scene ke scene lainnya tanpa kehilangan attribut data

		if (FindObjectsOfType(GetType()).Length > 1) //mencari apabila ada duplikasi object GGPs
		{
			Destroy(gameObject); //bila ada, maka hancurkan / hapus Object duplikatnya
		}
	}
}
