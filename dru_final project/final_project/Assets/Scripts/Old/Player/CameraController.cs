using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour {

	private Transform parentBody;
	//private Transform grandParentBody;
	// Use this for initialization

	void Start(){
		//grandParentBody = transform.parent.gameObject.transform.parent.gameObject.transform;
		parentBody = transform.parent.gameObject.transform;
	}

	void Awake () {
		Cursor.lockState = CursorLockMode.Locked;
	}
	
	// Update is called once per frame
	void Update () {
		Rotate ();
		Debug.Log (transform.parent.gameObject.transform.parent.gameObject.transform);
	}

	private void Rotate(){
		float MovX = Input.GetAxis ("Mouse X"); 
		float MovY= Input.GetAxis ("Mouse Y"); 

		Vector3 rotationCamera = transform.rotation.eulerAngles;
		Vector3 rotationBody = parentBody.rotation.eulerAngles;
		//Vector3 rotationGrandParent = grandParentBody.rotation.eulerAngles;

		rotationCamera.x -= MovY;
		rotationBody.y += MovX;
		//rotationGrandParent.y += MovX;

		transform.rotation = Quaternion.Euler (rotationCamera);
		parentBody.rotation = Quaternion.Euler (rotationBody);
		//grandParentBody.rotation = Quaternion.Euler(rotationGrandParent);
	}
}
