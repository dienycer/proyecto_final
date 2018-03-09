using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

	public AudioClip audioWalking;
	// Use this for initialization
	void Awake () {
		
	}
	

	void Update () {
		float verticalMovement = Input.GetAxis ("Vertical");
		float horizontalMovement = Input.GetAxis ("Horizontal");
		if (verticalMovement != 0.0f) {
			transform.Translate (transform.forward * verticalMovement * Time.deltaTime);
		}
	}


}
