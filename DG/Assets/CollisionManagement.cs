using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionManagement : MonoBehaviour {

	public float collisionSpeed;
	public float collisionSpeedThreshold = 1f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnCollisionStay(Collision col){

		//print (gameObject.name);


		collisionSpeed = col.relativeVelocity.magnitude;

		

			//print (col.gameObject.name + " " + speed);

			OSCHandler.Instance.SendMessageToClient("MaxMSP", "127.0.0.1", "Stay" + " " + "collisionSpeed" + " " + "PrimaryObject" + " " +
				collisionSpeed);

			//ekana prepend to collisionSpeed. Etsi meta mporw na kanw routing to value sto MaxMSP

			OSCHandler.Instance.SendMessageToClient ("MaxMSP", "127.0.0.1", "Stay" + " " + "collisionSpeed" + " " + col.gameObject.name + " " +
			collisionSpeed);
		
	}

		void OnCollisionEnter(Collision col){

			//print (gameObject.name);


			collisionSpeed = col.relativeVelocity.magnitude;

			

			OSCHandler.Instance.SendMessageToClient("MaxMSP", "127.0.0.1", "Enter" + " " + "collisionSpeed" + " " + "PrimaryObject" + " " +
				collisionSpeed);

			//print (col.gameObject.name + " " + speed);

			//ekana prepend to collisionSpeed. Etsi meta mporw na kanw routing to value sto MaxMSP

			OSCHandler.Instance.SendMessageToClient("MaxMSP", "127.0.0.1","Enter" + " " + "collisionSpeed" + " " + col.gameObject.name + " " +
					collisionSpeed);
			
		}
		

}
	
