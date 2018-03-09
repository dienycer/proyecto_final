using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class CubeMeshAgent : MonoBehaviour {
	
	NavMeshAgent iaAgent;


	//WayPoints
	[SerializeField]
	Transform[] positions;

	Transform actualWayPoint;
	int index;

	// Use this for initialization
	void Awake () {
		index = 0;
		actualWayPoint = positions[index];

		iaAgent = GetComponent<NavMeshAgent> ();
		iaAgent.SetDestination (actualWayPoint.position);
	}

	void Update(){
		//Debug.Log (Vector3.Distance(actualWayPoint.position, this.transform.position));
		if( iaAgent.remainingDistance < 2.5f){
			UpdateActualWayPoint ();
		}
		CheckIfPlayerIsNear ();
	}

	void UpdateActualWayPoint(){
		index = (index+1)% 4;
		/*if(index >= 4){
			index = 0;
		}*/
		actualWayPoint = positions[index];
		iaAgent.SetDestination (actualWayPoint.position);
	}

	private bool CheckIfPlayerIsNear(){
		bool playerIsNear = false;
		int layerMask = 1 << 8;
		Collider[] listOfColliders = Physics.OverlapSphere (this.transform.position, 6.0f, layerMask);

		int index = 0;

		while(index <listOfColliders.Length){
			playerIsNear = true;
				Renderer _m = listOfColliders [index].gameObject.GetComponent<Renderer> ();
				if (_m != null) {
					Debug.Log ("Color Changed");
					_m.material.color = Color.blue;
				}
			//} 
			index++;
		}
		return playerIsNear;
	}
}