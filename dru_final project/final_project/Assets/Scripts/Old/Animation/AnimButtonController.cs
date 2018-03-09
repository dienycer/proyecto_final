using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimButtonController : MonoBehaviour {

	private Animator anim;
	private Rigidbody rb;

	// Use this for initialization
	void Awake () {
		anim = GetComponent<Animator> ();
		rb = GetComponent<Rigidbody> ();
	}

	// Update is called once per frame
	void Update () {
		/*
		if (verticalMovement != 0.0f) {
			anim.SetBool ("esta_andando", true);
			anim.SetFloat ("speed", verticalMovement);

		} else {
			anim.SetBool ("esta_andando", false);
		}
*/
		if (Input.GetKeyDown ("space")) {
			rb.AddForce (new Vector3(0.0f, 10.0f, 0.0f), ForceMode.Impulse);
			anim.SetBool ("esta_saltando", true);
		}

	}


	public void moveForward(){
		anim.SetBool ("esta_andando", true);
		anim.SetFloat ("speed", 1.0f);
	}

	public void moveBack(){
		anim.SetBool ("esta_andando", true);
		anim.SetFloat ("speed", -1.0f);
	}

	public void moveLeft(){
		anim.SetBool ("esta_andando", true);
		anim.SetFloat ("speed", 1.0f);
	}

	public void moveRight(){
		anim.SetBool ("esta_andando", true);
		anim.SetFloat ("speed", 1.0f);
	}

	public void stop(){
		anim.SetBool ("esta_andando", false);
	}
	public void Jump(){
		rb.AddForce (new Vector3(0.0f, 10.0f, 0.0f), ForceMode.Impulse);
		anim.SetBool ("esta_saltando", true);
	}
	/*
	void OnCollisionEnter(){
		anim.SetBool ("esta_saltando", false);
	}*/
}
