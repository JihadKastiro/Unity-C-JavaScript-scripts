using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 

[RequireComponent(typeof(Rigidbody))]
public class KeyboardControllerScript : MonoBehaviour {
	public float movementSpeed;

	Rigidbody rB;
	void Start () {
		rB = GetComponent<Rigidbody> ();



	}

	void Update () {
		//transform    *  movementSpeed
if (Input.GetKey (KeyCode.W))
		{
		
			rB.position += Vector3.forward * Time.deltaTime *  movementSpeed;

		
		}else
			if (Input.GetKey (KeyCode.S))
			{

				rB.position += Vector3.back * Time.deltaTime *  movementSpeed ;


			}else
				if (Input.GetKey (KeyCode.A))
			{

					rB.position += Vector3.left * Time.deltaTime  *  movementSpeed;


				}else
					if (Input.GetKey (KeyCode.D))
					{

						rB.position += Vector3.right * Time.deltaTime  *  movementSpeed;


					}
		




	}
}
