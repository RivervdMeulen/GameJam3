using UnityEngine;
using System.Collections;

public class PickupSpeed : MonoBehaviour {
	private BoxCollider _pickUpCollider;
	private MeshRenderer _meshRenderer;
	// Use this for initialization
	void Start () {
		_pickUpCollider = GetComponent<BoxCollider>();
		_meshRenderer = GetComponent<MeshRenderer>();
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	void OnCollisionEnter(Collision other)
	{
		if(other.gameObject.tag == "Player1")
		{
			StartCoroutine (Wait());
		}
}

	private IEnumerator Wait(){
		yield return new WaitForSeconds (0.5f);
		_pickUpCollider.enabled = false;
		_meshRenderer.enabled = false;
	}
}