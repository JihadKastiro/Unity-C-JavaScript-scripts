using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class touchPadCOntroller : MonoBehaviour {
	public static touchPadCOntroller tpc;
	Rigidbody rb;
//public int movementSpeed;
	public static int verticalMove=0;
	public static int horizantalMove=0;
	// Use this for initialization
	void Awake () {
		rb = GetComponent<Rigidbody> ();

	}



	void Start(){
		tpc = this;
		verticalMove=0;
		horizantalMove=0;
	}


	// Update is called once per frame
	void Update () {
		
	}
	public void playerMoveUPPointerDown(){
		verticalMove = 1;
	
	}
	public void playerMoveUpPointerUp(){
		verticalMove = 0;

	}




	public void playerMoveDownPointerDown(){
		verticalMove = -1;

	}
	public void playerMoveDownPointerUp(){
		verticalMove = 0;

	}




	public void playerMoveRightPointerDown(){
		horizantalMove = 1;

	}
	public void playerMoveRightPointerUp(){
		horizantalMove = 0;

	}




	public void playerMoveLeftPointerDown(){
		horizantalMove = -1;

	}
	public void playerMoveLeftPointerUp(){
		horizantalMove = 0;

	}

	/*public void moveLeft(){
	
		rb.position += Vector3.left * Time.deltaTime  *  movementSpeed;

	}
	public void moveRight(){

		rb.position += Vector3.right * Time.deltaTime  *  movementSpeed;
		//rb.velocity=new Vector3(movementSpeed,0,0);

	}
	public void setVelocityToZero(){

	rb.velocity = Vector3.zero;
	}*/
}
