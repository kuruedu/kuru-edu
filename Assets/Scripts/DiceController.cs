using UnityEngine;
using System.Collections;

public class DiceController : MonoBehaviour {
	public int dadu;

    public int PutarDadu()
    {
        dadu = Random.Range(1, 7);
        return dadu;
    }
}
