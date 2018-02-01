using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour {

	AudioSource audioSource;
	Rigidbody rb;

	public float collisionThreshold = 2f;

	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody> ();
		audioSource = GetComponent<AudioSource> ();
	}


	void OnCollisionEnter(Collision collision) {
		foreach (ContactPoint contact in collision.contacts) {
			Debug.DrawRay (contact.point, contact.normal, Color.red);
		}
		if (collision.relativeVelocity.magnitude > collisionThreshold) {
			audioSource.Play ();
		}

		if (collision.gameObject.tag == "Destroyable") {
			Destroy (collision.gameObject);
		}

		print("Number of contacts " + collision.contacts.Length);
	}




	// Update is called once per frame
	void FixedUpdate () {
		float LeftRight = Input.GetAxis ("Horizontal");
		float UpDown = Input.GetAxis ("Vertical");
		float Jump = Input.GetAxis ("Jump");

		float speed = 8; //Time.deltaTime * 10;
		float jumpVelocity = 15f;

		Vector3 movement = new Vector3 (LeftRight, 0, UpDown);
		Vector3 jumping = new Vector3 (0, Jump, 0);

		rb.AddForce (movement * speed);
		//rb.AddExplosionForce (Jump * jumpVelocity, rb.position, 1f);
		rb.AddForce (jumping * jumpVelocity);

	}
}
