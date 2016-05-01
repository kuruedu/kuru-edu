using UnityEngine;
using System.Collections;

public class CamController : MonoBehaviour {

	public Transform target;
	private Transform followTransform;

	void Start(){
		followTransform = this.transform;
	}
	// Update is called once per frame
	void LateUpdate () {
		//this.transform.position = new Vector3 (target.transform.position.x, target.transform.position.y, -14.38f);
		followTransform.position = Vector2.Lerp(transform.position, target.position, Time.deltaTime * 5);
		this.transform.position = new Vector3 (followTransform.transform.position.x, followTransform.transform.position.y, -14.38f);
	}
}
