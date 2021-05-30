using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class touchcontroll : MonoBehaviour {
	public float movementSpeed;

	Rigidbody rB;
	// Use this for initialization
	void Start () {
		rB = GetComponent<Rigidbody> ();
	}

	/*
	void movePlayer(){
		CharacterController controller = GetComponent<CharacterController> ();
		if (controller.isGrounded) {

			moveDirection = new Vector3 (0, 0, touchPadCOntroller.playerMoveAxisTouch);
			moveDirection = transform.TransformDirection (moveDirection);
			moveDirection *= movementSpeed;
		}
	}

*/
	// Update is called once per frame
	void Update () {
		if (touchPadCOntroller.verticalMove==1)
		{

			rB.position += Vector3.forward * Time.deltaTime *  movementSpeed;


		}else
			if (touchPadCOntroller.verticalMove==-1)
			{

				rB.position += Vector3.back * Time.deltaTime *  movementSpeed ;


			}else
				if (touchPadCOntroller.horizantalMove==-1)
				{

					rB.position += Vector3.left * Time.deltaTime  *  movementSpeed;


				}else
					if (touchPadCOntroller.horizantalMove==1)
					{

						rB.position += Vector3.right * Time.deltaTime  *  movementSpeed;


					}




	}
}
