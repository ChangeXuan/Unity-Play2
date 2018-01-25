using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCamera : MonoBehaviour {

	public float speed = 10f;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		float moveX = Input.GetAxis ("Horizontal");
		float moveY = Input.GetAxis ("Vertical");
		if (transform.position.y < 0.5f && moveY < 0) {
			moveY = 0f;
		}
		transform.Translate (new Vector3 (moveX, moveY, 0)*Time.deltaTime*speed);


	}
}
