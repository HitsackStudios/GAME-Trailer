using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class newplayerbed : MonoBehaviour {

	public float walk;
	float move;
	float holdwall;
	Rigidbody myRB;
	Animator myAM;

	void Start () {
		myRB = GetComponent<Rigidbody> ();
		myAM = GetComponent<Animator> ();
	}
	void Update () {
		
	}

	void FixedUpdate () {
		move = Input.GetAxis ("Horizontal") ;
		holdwall = Input.GetAxis ("Vertical");

		myAM.SetFloat ("walk",Mathf.Abs (move));
		myAM.SetFloat ("window",Mathf.Abs(holdwall));

		myRB.velocity = new Vector3 (move * walk, myRB.velocity.y,0);
		//myRB.velocity = new Vector3 (holdwall * walk, myRB.velocity.y,0);
	}
}
