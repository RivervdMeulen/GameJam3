using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class SceneController : MonoBehaviour
{
	public void LoseGame()
	{
		SceneManager.LoadScene ("LoseScreen");
	}

	public void WinGame()
	{
		SceneManager.LoadScene ("WinScreen");
	}

	public void StartGame()
	{
		SceneManager.LoadScene ("MainGame");
	}
}
