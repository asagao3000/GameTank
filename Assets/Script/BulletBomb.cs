using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletBomb : MonoBehaviour {

	public GameObject bulletBomb;
	public GameObject SE;

	void OnCollisionEnter(){
		
		GameObject bomb = Instantiate (bulletBomb, this.gameObject.transform.position, this.gameObject.transform.rotation);
		bomb.GetComponent<Detonator> ().Explode ();
		Instantiate (SE, this.gameObject.transform.position, this.gameObject.transform.rotation);
		Destroy (this.gameObject);
	}
}
