using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class BeginTimer : MonoBehaviour {

	[SerializeField]
	private Text _countDownText;

	public float startCount;

	private string countShown;

	private bool showCount = true;

	void Start () {
		Time.timeScale = 0.01f;
		StartCoroutine (CountCoroutine());
	}

	/*
	void Update ()
	{
		if (startCount <= 0)
		{
			//Hier stopt de game.
			Time.timeScale = 0;
			_countDownText.text = "Start!";
		}

		else
		{
			StartCoroutine(CountCoroutine());
		}
	}
	*/

	IEnumerator CountCoroutine()
	{
		startCount--;

		if (showCount) {
			countShown = startCount.ToString();
		}

		if (startCount < 1) {
			_countDownText.text = "Start!";
			Time.timeScale = 1;
			showCount = false;
			countShown = "Start!";
		}

		if (startCount < -8) {
			_countDownText.text = " ";
			countShown = " ";
		}
			
		_countDownText.text = string.Format (countShown.ToString());

		yield return new WaitForSeconds(0.01f);
		StartCoroutine (CountCoroutine ());
	}

}
