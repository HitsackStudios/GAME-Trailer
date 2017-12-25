using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeroController : MonoBehaviour {

	public float walkSpeed;
	float move;

	Rigidbody myRB;
	Animator myAM;

	void Start () {
		myRB = GetComponent<Rigidbody> ();
		myAM = GetComponent<Animator> ();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void FixedUpdate () {
		move = Input.GetAxis ("Horizontal");
		//myRB.velocity = new Vector3 (move * walkSpeed, myRB.velocity.y, 0);
        transform.Translate(Vector3.forward * Time.deltaTime * walkSpeed);
    }

}
