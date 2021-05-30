using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotateScript : MonoBehaviour {
	public  Transform tf;
	
	public float xyz;
	
	void Update () {
		Vector3 a = new Vector3 (0,xyz,0);
		
		tf.RotateAround(a,30);

	}
}
