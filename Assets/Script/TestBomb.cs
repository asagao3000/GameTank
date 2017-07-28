using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestBomb : MonoBehaviour {

	// Use this for initialization
	void OnMouseDown(){
		this.gameObject.GetComponent<Detonator> ().Explode ();
	}
}
