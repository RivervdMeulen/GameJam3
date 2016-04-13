using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour {

	public float speed = 10.0F;
	public float rotationSpeed = 100.0F;
	private bool GoFast = false;
	void Update() {
		float translation = Input.GetAxis("Vertical") * speed;
		float rotation = Input.GetAxis("Horizontal") * rotationSpeed;
		translation *= Time.deltaTime;
		rotation *= Time.deltaTime;
		transform.Translate(0, 0, -translation);
		transform.Rotate(0, rotation, 0);
	}
	void OnCollisionStay(Collision other)
	{
		if (other.gameObject.tag == "SlowField")
		{
			speed = 5f;
		}
		else if(GoFast == false)
		{
			speed = 30f;
		}
	}

	void OnCollisionEnter(Collision Coll)
	{
		if(Coll.gameObject.tag == "SpeedPickup")
		{
			StartCoroutine (SpeedUP());
			Debug.Log ("GoFast");
		}
		else if(GoFast == false)
		{
			speed = 30f;
		}
	}

	private IEnumerator SpeedUP()
	{
		
		GoFast = true;
		speed = 100f;
		yield return new WaitForSeconds (3f);
		GoFast = false;
	}

}


