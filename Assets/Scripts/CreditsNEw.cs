using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class CreditsNEw : MonoBehaviour {

    public float speed = 1.0f;
	public int creditTime = 5;
    public GameObject textCredits;
    public bool roll = false;
	public Transform targettransform;
	// Update is called once per frame
	void Update () {
        if (roll)
        {
			textCredits.transform.position = Vector3.Lerp(textCredits.transform.position, targettransform.position, Time.deltaTime * speed);
			StartCoroutine (stopRoll ());
		}
    }

	IEnumerator stopRoll(){
		yield return new WaitForSeconds (creditTime);
		roll = false;
		GameObject.Find ("Canvas").GetComponent<MenuController> ().pergiKePanel (4);
		textCredits.transform.position = new Vector2 (textCredits.transform.position.x, -661);
	}

}
