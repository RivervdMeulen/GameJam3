using UnityEngine;
using System.Collections;

public class EndPoint : MonoBehaviour
{
	private SceneController sceneController;

	void OnTriggerEnter(Collider other)
	{
		if(other.CompareTag("player"))
		{
			sceneController.WinGame ();
		}
		if(other.CompareTag("AI"))
		{
			sceneController.LoseGame ();
		}
	}
}