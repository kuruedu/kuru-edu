using UnityEngine;
using System.Collections;

public class DiceController : MonoBehaviour {
	public int dadu;
	public GameObject daduOBJ;

	void Start(){

	}

    public int PutarDadu()
    {
        dadu = Random.Range(1, 7); //generate random 
        return dadu;
    }
}
