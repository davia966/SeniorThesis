﻿using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {

	public float speed;
	public Inventory inventory;
	GameObject itemAdd;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		HandleMovement();
	
	}

	private void HandleMovement(){
		float translation = speed * Time.deltaTime;

		transform.Translate(new Vector3 (Input.GetAxis("Horizontal") * translation,0,Input.GetAxis("Vertical") * translation));
	}

	private void OnTriggerEnter (Collider other){
//		if (other.tag == "Item"){
//			if (Input.GetMouseButtonDown(3)){
//				inventory.AddItem(other.GetComponent<Item>());
//				Debug.Log ("ROCKS!!!!");
//			}
//		}
		if (other.tag == "Item"){
			inventory.AddItem(other.GetComponent<Item>());
			Debug.Log ("Rock it bitch!");
		}
	}
}
