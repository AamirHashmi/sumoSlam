using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class menu : MonoBehaviour {

	public void playGame()
	{
		Scene playLevel1 = SceneManager.GetActiveScene ();
		SceneManager.LoadScene ("level1");
	}

	public void goBackToMenu()
	{
		Scene menu = SceneManager.GetActiveScene ();
		SceneManager.LoadScene ("menu");
	}

	public void quitGame()
	{
		Application.Quit ();
	}
}
