using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallHandler : MonoBehaviour {
	//public GameObject
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnCollisionEnter(Collision coll) {
		if (coll.gameObject.CompareTag ("Ground")) {
			gameObject.SetActive (false);
		}
	}
}
