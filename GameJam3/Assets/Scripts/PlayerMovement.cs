using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour {

	public float speed = 10.0F;
	public float rotationSpeed = 100.0F;
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
			speed = 1f;
		}
		else
		{
			speed = 10f;
		}
	}
}


