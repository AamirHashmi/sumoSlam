using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement2 : MonoBehaviour {

	public Rigidbody playerRb;
	public int speed;
	public BoxCollider playerBc;
	public PhysicMaterial bouncy;

	public Vector3 test;
	public GameObject shield;
	public TrailRenderer trail;
	private Vector3 shieldScale;
	public bool canShield;
	public Vector3 spawnPoint;

	// Use this for initialization
	void Start () {
		speed = 10;
		test.y = 6;
		trail.enabled = false;
		spawnPoint.z = 1;
		spawnPoint.y = 1;
		//canShield = false;

	}

	// Update is called once per frame
	void Update () {

		//if(canShield == false) 
		//{
		//	StartCoroutine (shieldRecharge ());
		//}

		if(Input.GetKey("up"))
		{
			moveUp ();
		}

		if(Input.GetKey("left"))
		{
			moveLeft ();
		}

		if(Input.GetKey("down"))
		{
			moveDown ();
		}

		if(Input.GetKey("right"))
		{
			moveRight ();
		}

		if (Input.GetKeyDown (".")) 
		{
			StartCoroutine(bounce ());
		}

		if (Input.GetKeyDown("/") /*&& canShield == true*/) 
		{
			StartCoroutine (shieldOn ());
		}

		if(Input.GetKey("t"))
		{
			testTeleport ();

		}
	}

	public void OnCollisionEnter(Collision info)
	{
		if (info.collider.tag == "player") {

		}
	}

	public void moveUp()
	{
		playerRb.AddForce (0,0,speed);
	}

	public void moveDown()
	{
		playerRb.AddForce (0, 0, -speed);
	}

	public void moveLeft()
	{
		playerRb.AddForce (-speed, 0, 0);
	}

	public void moveRight()
	{
		playerRb.AddForce (speed, 0, 0);
	}

	public IEnumerator bounce()
	{
		if(Input.GetKey("up"))
		{
			playerRb.AddForce (0,0,400);
		}
		if(Input.GetKey("left"))
		{
			playerRb.AddForce (-400,0,0);
		}
		if(Input.GetKey("down"))
		{
			playerRb.AddForce (0,0,-400);
		}
		if(Input.GetKey("right"))
		{
			playerRb.AddForce (400,0,0);
		}

		trail.enabled = true;
		yield return new WaitForSeconds (0.5f);
		trail.enabled = false;

	}

	public IEnumerator shieldOn()
	{
		shieldScale.Set (1.5f, 1.5f, 1.5f); //enlarges shield
		shield.transform.localScale =shieldScale;

		playerRb.mass = 10;//makes player heavier while shielding so they dont fly as far.
		playerRb.velocity = Vector3.zero;//slows down player

		yield return new WaitForSeconds(0.5f);

		shieldScale.Set (0f, 0f, 0f);//decreases shield size
		shield.transform.localScale =shieldScale;
		playerRb.mass = 1;//returns the mass to normal.

		//canShield = false;
	}

	public void testTeleport()
	{

		playerRb.MovePosition (test);

	}

	public void respawn()
	{
		Vector3 spawn;
		spawn.x = 0;          //player 1 respawn coordinates.
		spawn.y = 4;
		spawn.z = 0;
		playerRb.MovePosition (spawn);
	}

	public IEnumerator shieldRecharge()
	{
		yield return new WaitForSeconds(10.0f);
		//canShield = true;

	}

	public void respawnPlayer2()
	{

		playerRb.position =  spawnPoint;
		playerRb.velocity = Vector3.zero;
	}

}
