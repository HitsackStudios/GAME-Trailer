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
        transform.Translate(Vector3.forward * Time.deltaTime);
        //transform.Translate(Vector3.up * Time.deltaTime, Space.World);
    }
}
	