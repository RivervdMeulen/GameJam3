using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class EndPoint : MonoBehaviour
{
	void OnTriggerEnter(Collider other)
	{
		if(other.CompareTag("player"))
		{
			SceneManager.LoadScene ("WinScreen");
		}
		if(other.CompareTag("AI"))
		{
			SceneManager.LoadScene ("LoseScreen");
		}
	}
}