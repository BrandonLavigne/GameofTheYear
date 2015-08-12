﻿using UnityEngine;
using System.Collections;

public class Reset : MonoBehaviour {
	public MeshRenderer reset;
	// Use this for initialization
	void Start () {
		reset.enabled = false;	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnCollisionEnter2D(Collision2D coll) {
		if (coll.gameObject.tag == "spineboy") {
			Application.LoadLevel(Application.loadedLevel);
		}
	}
}