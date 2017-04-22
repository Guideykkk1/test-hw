using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerController : MonoBehaviour {
	public Rigidbody rb;
	public float speed;
	public float titl;
	public GameObject shot;
	public Transform shotSpawn;
	public float fireRate;
	private float nextFire;


	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody> ();
				
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		float moveHorizontal = Input.GetAxis ("Horizontal");
		float moveVertical = Input.GetAxis ("Vertical");
		Vector3 movement = new Vector3 (moveHorizontal, 0.0f, moveVertical);
		rb.velocity = movement * speed;
					
	
		
	}

	void Update()
	{
		if (Input.GetButton ("Fire1") && Time.time > nextFire) {
			nextFire = Time.time + fireRate;
			Instantiate (shot, shotSpawn.position, shotSpawn.rotation);

		}
	}

}
