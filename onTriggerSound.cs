using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class onTriggerSound : MonoBehaviour {
	public AudioSource soundSourcez;
	public AudioClip sound;

	private bool hasPlayedAudio;


	private void OnTriggerEnter(Collider other)
	{
	//	if ((other.tag == "Player")&&(hasPlayedAudio==false)) {
		if (other.tag == "Player"){
			soundSourcez.PlayOneShot (sound);
			//hasPlayedAudio = false;
		}
	}
}
