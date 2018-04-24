using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coins : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        transform.Rotate(90 * Time.deltaTime, 0, 0);
		
	}

     void OnTriggerEnter2D(Collider2D collision)
    {
       
        Destroy(gameObject);
    }



}
