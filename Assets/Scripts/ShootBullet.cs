using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootBullet : MonoBehaviour {

	public GameObject bullet;
	public float speed = 5f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButtonDown (0)) {
			GameObject shootBullet = GameObject.Instantiate (bullet, transform.position,transform.rotation);
			Rigidbody rgd = shootBullet.GetComponent<Rigidbody> ();
			rgd.velocity = transform.forward*Time.deltaTime*speed;

		}
	}
}
