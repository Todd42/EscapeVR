using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StaticFade : MonoBehaviour {

	public GameObject thing;
	public float sweetSpot;
	public float originalRotation;

	private float ang;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		ang = transform.eulerAngles.x - originalRotation;
		thing.GetComponent<SpriteRenderer>().color = new Color(1f,1f,1f, 0.0f + Mathf.Abs((sweetSpot - ang)/80));
	}

	//public onCollisionEnter(){
	//	ang = transform.eulerAngles.x - originalRotation;
	//thing.GetComponent<SpriteRenderer>().color = new Color(1f,1f,1f, 0.0f + Mathf.Abs((sweetSpot - ang)/80));
	//}

}
