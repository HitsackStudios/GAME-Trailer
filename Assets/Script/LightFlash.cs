using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightFlash : MonoBehaviour {

    public float minTime = 0.5f;
    public float threshhold = 0.5f;
    public Light mylight;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Time.time > minTime) {
            if (Random.value > threshhold)
            {
                mylight.enabled = true;
            }
            else
                mylight.enabled = false;
        }
		
	}
}
