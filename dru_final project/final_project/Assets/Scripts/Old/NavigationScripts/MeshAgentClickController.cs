using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class MeshAgentClickController : MonoBehaviour {

	public Camera cam;
	public LayerMask layer;
	private NavMeshAgent meshAgent;
	// Use this for initialization
	void Awake () {
		meshAgent = GetComponent<NavMeshAgent> ();
	}
	
	// Update is called once per frame
	void Update () {

		if(Input.GetMouseButtonDown(0)){
			Vector3 destination = getPointOnClick ();
			if (destination != new Vector3 (0, 0, 0)) {
				meshAgent.SetDestination (destination);
			}
		}
	}


	private Vector3 getPointOnClick(){
		// Get Mouse Position
		Vector3 pos =  Input.mousePosition;
		Vector3 realPos;

		Ray ray = cam.ScreenPointToRay (Input.mousePosition);
		RaycastHit hit;

		if (Physics.Raycast (ray, out hit, 1000, layer)) {
			//Debug.Log (hit.transform.gameObject.name);
			Debug.Log (hit.point);
			realPos = hit.point;
		} else {
			Debug.Log ("NO HIT!");
			realPos = new Vector3 (0, 0, 0);
		}

		return realPos;

	}


}
