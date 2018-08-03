using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class prox : MonoBehaviour {
	public Vector3 pointOfContact;
	public BoxCollider playerBc;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter(Collision playerBc )
	{
		pointOfContact = playerBc.collider.ClosestPointOnBounds();

	}
}
