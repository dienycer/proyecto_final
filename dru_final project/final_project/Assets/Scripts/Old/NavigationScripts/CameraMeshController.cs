using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMeshController : MonoBehaviour {


	public GameObject ob;

	private Vector3 diff;


	// Use this for initialization
	void Awake () {
		this.diff = transform.position - ob.transform.position;
	}
	
	// Update is called once per frame
	void LateUpdate () {
		this.transform.position = ob.transform.position + this.diff;
	}
}
