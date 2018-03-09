using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimController : MonoBehaviour {

	private Animator anim;
	private Rigidbody rb;
	// Use this for initialization
	void Start () {
		anim = GetComponent<Animator> ();
		rb = GetComponent<Rigidbody> ();
	}
	
	// Update is called once per frame
	void Update () {
		float verticalMovement = Input.GetAxisRaw ("Vertical");
		if (verticalMovement != 0.0f) {
			anim.SetBool ("esta_andando", true);
			anim.SetFloat ("speed", verticalMovement);

		} else {
			anim.SetBool ("esta_andando", false);
		}

		if (Input.GetKeyDown ("space")) {
			rb.AddForce (new Vector3(0.0f, 10.0f, 0.0f), ForceMode.Impulse);
			anim.SetBool ("esta_saltando", true);
		}
		
	}


	public void Jump(){
		rb.AddForce (new Vector3(0.0f, 10.0f, 0.0f), ForceMode.Impulse);
		anim.SetBool ("esta_saltando", true);
	}

	void OnCollisionEnter(Collision c){
		anim.SetBool ("esta_saltando", false);
		
	}
}
