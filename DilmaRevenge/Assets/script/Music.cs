using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Music : MonoBehaviour {

	public Texture2D musicOn; 
	public Texture2D musicOff; 
	public bool ativo;



	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		AudioSource a = GetComponent<AudioSource> ();
		GUITexture g = GetComponent<GUITexture>();

		if(ativo) {
			a.mute = false;
			g.texture = musicOn;
		} else {
			a.mute = true;
			g.texture = musicOff;
		}	
	}
	void OnMouseDown() {
		ativo = !ativo;
	}
}
