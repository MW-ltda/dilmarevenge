using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveOffset : MonoBehaviour {

	private Material currentMaterial;
	private float speed;
	private float offSet;


	// Use this for initialization
	void Start () {
		currentMaterial = GetComponent<Renderer>().material;


	}

	// Update is called once per frame
	void Update () {
		offSet += 0.001f;

		currentMaterial.SetTextureOffset("_MainTex", new Vector2(offSet,0));

	}
}
