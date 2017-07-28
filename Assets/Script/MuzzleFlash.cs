using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class MuzzleFlash : NetworkBehaviour {

	public GameObject muzzle;
	public GameObject muzzleFlash;
	public float reloadTime = 2f;
	float time = 0f;


	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
			if (Input.GetKeyDown (KeyCode.Space) && time >= reloadTime) {

				CmdCreateMuzzleFlash();
				time = 0f;

			} else if (time <= reloadTime) {

				time += Time.deltaTime;

			}


	}

	[Command]
	void CmdCreateMuzzleFlash(){
		GameObject flash = Instantiate (muzzleFlash, muzzle.transform.position, muzzle.transform.rotation)as GameObject;
		NetworkServer.Spawn (flash);
		flash.GetComponent<Detonator> ().Explode ();

	}
}
