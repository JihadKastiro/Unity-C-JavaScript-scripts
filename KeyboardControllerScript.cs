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
		

/*		if (Input.GetAxis("Horizontal")>=0)
		{

			//rB.position += Vector3.right * Time.deltaTime  *  movementSpeed;
			transform.Translate (Input.GetAxis("Horizontal")*Time.deltaTime*movementSpeed,0f,0f);
		}

		if (Input.GetAxis("Horizontal")<0)
		{

			//rB.position += Vector3.right * Time.deltaTime  *  movementSpeed;
			transform.Translate (Input.GetAxis("Horizontal")*Time.deltaTime*movementSpeed,0f,0f);
		}
		if (Input.GetAxis("Vertical")<0)
		{

			//rB.position += Vector3.right * Time.deltaTime  *  movementSpeed;
			transform.Translate (0f,0f,Input.GetAxis("Vertical")*Time.deltaTime*movementSpeed);
		}
		if (Input.GetAxis("Vertical")>0)
		{

			//rB.position += Vector3.right * Time.deltaTime  *  movementSpeed;
			transform.Translate (0f,0f,Input.GetAxis("Vertical")*Time.deltaTime*movementSpeed);
		}
		*/

	//	transform.Translate (Input.GetAxis("Horizontal")*Time.deltaTime,Input.GetAxis("Vertical")*Time.deltaTime,0f);



	}
}
