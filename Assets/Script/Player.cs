using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
	public float sp;
	public Rigidbody rb;
	public Transform ts;
	public AudioClip idling;
	public AudioClip move;
	public int life = 100;
	private AudioSource audioSource;
	int i = 0;
	int nowplaying = -1;

	void Start ()
	{
		
		rb = GetComponent<Rigidbody> ();
		ts = GetComponent<Transform> ();
		audioSource = gameObject.GetComponent<AudioSource> ();
		audioSource.clip = idling;
		audioSource.Play ();

	}

	void OnCollisionEnter(Collision collision){
		string yourTag = collision.gameObject.tag;
		//この辺デバッグ用
		if (yourTag == "Bullet") {
			life -= 10;
			Debug.Log (life);
		}


	}

	
	// Update is called once per frame
	void Update ()
	{
		//この辺デバッグ用
		if (life <= 0) {
			Debug.Log ("GAME OVER");
			life = 100;
		}

		if (Input.GetKey ("w")) {
			rb.velocity = ts.right * sp;
		}
		if (Input.GetKey ("s")) {
			rb.velocity = ts.right * -sp;
		}
		if (Input.GetKey ("d")) {
			transform.Rotate (0f, 0.5f, 0f);
		}
		if (Input.GetKey ("a")) {
			transform.Rotate (0f, -0.5f, 0f);
		}

		if (Input.GetKey ("w") || Input.GetKey ("s") || Input.GetKey ("d") || Input.GetKey ("a")) {
				if (nowplaying!=1) {
				audioSource.clip = move;
				audioSource.Play ();
				nowplaying = 1;
			}
		} else {
			if (nowplaying!=2) {
				audioSource.clip = idling;
				audioSource.Play ();
				nowplaying = 2;
			}
		}

	}
}
