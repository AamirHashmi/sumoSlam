using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class winnertext : MonoBehaviour {

	public deathCollision dc;
	public Text win;
	public Text winnerText;
	public Button restart;
	public Button quit;
	public GameObject hud;
	// Use this for initialization
	void Start () {
		Time.timeScale = 1f;
		win.enabled = false;
		winnerText.enabled = false;
		hud.gameObject.SetActive(false);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void showWinner()
	{
		winnerText.text = dc.winner;
		winnerText.enabled = true;
		win.enabled = true;
		hud.gameObject.SetActive(true);
		Time.timeScale = 0f;//freezez game.
	}
}
