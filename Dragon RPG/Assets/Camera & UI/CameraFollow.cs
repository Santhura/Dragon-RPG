using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour {

    GameObject player;

	// Use this for initialization
	void Start () {
        player = GameObject.FindWithTag("Player");

	}
	
    private void LateUpdate()
    {
        transform.position = player.transform.position;
    }
}
