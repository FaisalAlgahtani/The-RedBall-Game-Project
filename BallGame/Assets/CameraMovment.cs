using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovment : MonoBehaviour {

    public Transform playerBall;
    public Vector3 offset;
	
	// Update is called once per frame
	void Update () {
        transform.position = playerBall.position + offset;

	}
}
