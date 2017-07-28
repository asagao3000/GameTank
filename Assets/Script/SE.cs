using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SE : MonoBehaviour {

	float time = 0f;

	// Use this for initialization
	void Start () {
		gameObject.GetComponent<AudioSource> ().Play ();


	}
	
	// Update is called once per frame
	void Update () {

		if (time >= 2) {
			Destroy (this.gameObject);
		} else if (time < 2) {

			time += Time.deltaTime;
		}
		
	}
}
