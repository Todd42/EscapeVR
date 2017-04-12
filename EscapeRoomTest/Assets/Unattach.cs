using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Unattach : MonoBehaviour {

	private bool ring;

	public GameObject screen;
	public GameObject lighty;

	private int count;

	// Use this for initialization
	void Start () {
		//other = GetComponent<VRTK.VRTK_InteractableObject> ().GetGrabbingObject();
		GetComponent<Rigidbody> ().useGravity = false;
		ring = true;
	}
	
	// Update is called once per frame
	void Update () {
		if (ring) {
			count++;
			if(count >= 300){
				//lighty.GetComponent<Light>().intensity = 0.0f;
				lighty.SetActive (true);
				count = 0;
			}
			if (count == 30) {
				//lighty.GetComponent<Light>().intensity = 0.8f;
				lighty.SetActive(false);
			}
		}

		if(GetComponent<VRTK.VRTK_InteractableObject>().IsGrabbed()){
			GetComponent<Rigidbody> ().useGravity = true;
			ring = false;
			screen.SetActive (true);
		}

	}
}
