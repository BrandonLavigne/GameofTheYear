﻿using UnityEngine;
using System.Collections;

public class BlingPickup : MonoBehaviour {
	private bool Blinged;//Got Em!
	//public GameObject Sprite;
	public ParticleSystem Particles;
	public SpriteRenderer SpriteRender;
	private God Blingerino;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter2D(Collider2D coll) {
		if (coll.gameObject.tag == "spineboy" && Blinged == false) {
			Blinged = true;
			//Sprite.SetActive(false);
			SpriteRender.enabled = false;
			Particles.Emit(10);
			Invoke ("DestroyMe", 0.5f);

			if (Blingerino == null){
				Blingerino = GameObject.FindGameObjectWithTag ("God").GetComponent<God>();
			}
			Blingerino.Blingerino ();
		}
	}
	void DestroyMe(){
		Destroy (this.gameObject );
	}
}
