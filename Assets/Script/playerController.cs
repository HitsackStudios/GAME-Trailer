using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerController : MonoBehaviour
{
     
    void Start()
    {
       
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow)) {
    Vector3 position = this.transform.position;
    position.y++;
    this.transform.position = position;
	}
    }
}
	