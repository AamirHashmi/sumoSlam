using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HUD : MonoBehaviour {

	public void goBackToMenu()
	{
		Scene menu = SceneManager.GetActiveScene ();
		SceneManager.LoadScene ("menu");
	}

	public void reload()
	{
		Scene level1 = SceneManager.GetActiveScene ();
		SceneManager.LoadScene ("level1");
	}
}
