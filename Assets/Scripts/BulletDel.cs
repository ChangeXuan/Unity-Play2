using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletDel : MonoBehaviour {

	private float groundH;

	// Use this for initialization
	void Start () {
		groundH = GameObject.Find ("Ground").transform.position.y;
	}
	
	// Update is called once per frame
	void Update () {
		if (transform.position.y < groundH) {
			Destroy(this.gameObject);
		}
	}
}
