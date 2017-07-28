using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class First : NetworkBehaviour {


	public Camera mainCamera;
	public AudioListener listener;
	public GameObject muzzle;

	// Use this for initialization
	void Start () {

		if (isLocalPlayer) {

			GetComponent<BoxCollider> ().enabled = true;
			GetComponent<Shoot> ().enabled = true;
			GetComponent<Player> ().enabled = true;
			GetComponent<MuzzleFlash> ().enabled = true;

			listener.enabled = true;
			mainCamera.enabled = true;

		}

	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
