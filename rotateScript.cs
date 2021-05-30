using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotateScript : MonoBehaviour {
	public  Transform tf;
	//public float angle;
	public float xyz;
	//public Vector3andSpace rotateDegreesPerSecond;
	// Update is called once per frame
	void Update () {
		Vector3 a = new Vector3 (0,xyz,0);
		//tf.RotateAround (a,angle);
		tf.RotateAround(a,30);

		//tf.rot
		// transform.Rotate(rotateDegreesPerSecond.value*deltaTime, moveUnitsPerSecond.space);
	}
}
