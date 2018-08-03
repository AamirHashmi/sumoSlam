using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour {

	public Rigidbody playerRb;
	public Vector3 offset;

	// Use this for initialization
	void Start () {
		offset.z = -10;
		Input.GetAxisRaw ("Mouse Y");
		Input.GetAxisRaw ("Mouse X");
	}
	
	// Update is called once per frame
	void Update () {
		transform.position = playerRb.position + offset;
	}
}
