using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class BulletBomb : NetworkBehaviour {

	public GameObject bulletBomb;
	public GameObject SE;


	void OnCollisionEnter(){
		CmdCreate ();

	}

	[Command]
	void CmdCreate(){
		GameObject bomb = Instantiate (bulletBomb, this.gameObject.transform.position, this.gameObject.transform.rotation);
		NetworkServer.Spawn (bomb);
		bomb.GetComponent<Detonator> ().Explode ();
		GameObject se = Instantiate (SE, this.gameObject.transform.position, this.gameObject.transform.rotation);
		NetworkServer.Spawn (se);
		Destroy (this.gameObject);

	}

}
