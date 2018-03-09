
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animator_controller : MonoBehaviour {

	private Animator anim; 
	private Rigidbody rb;

	// Use this for initialization
	void Start () {
		anim = GetComponent<Animator> ();
	}

	// Update is called once per frame
	void Update () {

		float verticalMovement = Input.GetAxisRaw ("Vertical");
		if (verticalMovement != 0.0f) {
			anim.SetBool ("Walk", true);
		} else {
			anim.SetBool ("Walk", false);
		}

		if (Input.GetKey ("space")) {
			anim.SetBool ("Jump", true);
		} else {
			anim.SetBool ("Jump", false);
		}


		if (Input.GetMouseButtonDown (0)) {
			anim.SetBool ("Attack", true);
		} else {
			anim.SetBool ("Attack", false);
		}
	}

	void OnCollisionEnter (Collision c){
		Debug.Log ("HOLAAAAAAAAAAAAAAA");
		anim.SetBool ("jumping", false);

	}
}
