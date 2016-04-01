using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

	public int currentPos = 0;
	public bool isQuiz;

	public TileController TC;

	// Use this for initialization
	void Start () {
		TC = GameObject.Find ("GameManager").GetComponent<TileController> ();
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown ("w")) {
			moveToNext ();
		}
		transform.position = Vector3.Lerp(transform.position, TC.Tiles [currentPos].transform.position, Time.deltaTime);
	}

	public void moveToNext(){
		if (currentPos + 1 < TC.Tiles.Length) {
			currentPos += 1;
			//this.transform.position = TC.Tiles [currentPos].transform.position;
		} else {
			print ("Finish");
		}
	}
}
