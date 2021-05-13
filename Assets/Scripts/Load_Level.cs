using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Load_Level : MonoBehaviour {
	private string[] scenePaths;

	public void MainMenu()
	{
		SceneManager.LoadScene("MainMenu");
	}

	public void Level1()
	{
		SceneManager.LoadScene ("Przyklad");
	}

	public void Level2()
	{
		SceneManager.LoadScene("Level2");
	}

	public void Level3()
	{
		SceneManager.LoadScene("Level3");
	}

	public void Level4()
	{
		SceneManager.LoadScene("Level4");
	}
}
