using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ToggleBehaviour : MonoBehaviour {


	public Scrollbar scrollbar;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void ChangeScrollBar(){
		Toggle t = GetComponent<Toggle> ();
		if (t.isOn) {
			scrollbar.value = 1.0f;
		} else {
			scrollbar.value = 0.0f;
		}
	}
}
