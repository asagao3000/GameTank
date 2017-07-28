using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MuzzleFlash : MonoBehaviour {

	public GameObject muzzle;
	public GameObject muzzleFlash;
	public float reloadTime = 2f;
	float time = 0f;


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		if (Input.GetKeyDown (KeyCode.Space) && time > reloadTime) {

			GameObject flash = Instantiate (muzzleFlash,this.transform.position, muzzle.transform.rotation)as GameObject;
			flash.GetComponent<Detonator> ().Explode ();

			time = 0f;

		} else if(time <=reloadTime){

			time += Time.deltaTime;

		}

	}
}
