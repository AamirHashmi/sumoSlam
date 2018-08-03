using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class deathCollision : MonoBehaviour {

	public BoxCollider playerBc;
	public movement player1Movement;
	public movement2 player2Movement;
	public int player1Score;
	public int player2Score;
	public string winner;
	public winnertext wt;


	void OnTriggerEnter(Collider playerBc)
	{
		if (playerBc.tag == "player") {
			Debug.Log ("Dead");
			//StartCoroutine (trackScore());

			if (playerBc.name == "player2") {
				player1Score++;
			}

			if (playerBc.name == "player1") {
				player2Score++;
			}
				
			player1Movement.respawnPlayer1();
			player2Movement.respawnPlayer2();
		}
	}


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(player1Score == 3)
		{
			winner = "PLAYER 1";
			wt.showWinner ();
		}

		if(player2Score == 3)
		{
			winner = "PLAYER 2";
			wt.showWinner ();
		}
	}

	public IEnumerator trackScore()
	{
		

		yield return new WaitForSeconds (1.0f);

	}
}
