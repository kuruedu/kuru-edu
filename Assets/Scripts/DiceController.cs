using UnityEngine;
using System.Collections;

public class DiceController : MonoBehaviour {

    public int PutarDadu()
    {
        int dadu = Random.Range(1, 7);
        return dadu;
    }
}
