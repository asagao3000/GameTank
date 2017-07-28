using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour {

	public GameObject bullet;
	public Transform muzzle;
	public float speed = 1000;
	public float reloadTime = 2.0f;
	public AudioClip shot;
	float time = 0f;






	// Update is called once per frame
	void Update () {

		if (Input.GetKeyDown (KeyCode.Space) && time > reloadTime) {

			GameObject bullets = Instantiate (bullet, muzzle.transform.position, muzzle.transform.rotation)as GameObject;

			bullets.GetComponent<Rigidbody> ().AddForce (muzzle.transform.up * speed);
			bullets.transform.position = muzzle.position;

			GetComponent<AudioSource> ().PlayOneShot (shot);

			time = 0f;
		} else if (time < reloadTime) {

			time += Time.deltaTime;

		}




	}
}
