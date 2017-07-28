using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy : MonoBehaviour {

	public float lifeTime = 1.5f;
	float time = 0f;


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		time += Time.deltaTime;

		if (time > lifeTime) {

			Destroy (this.gameObject);


		}

	}
}
