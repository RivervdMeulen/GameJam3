using UnityEngine;
using System.Collections;

public class EnemyAI : MonoBehaviour {

	private NavMeshAgent _navMeshAgent;
	private GameObject _endPointObj;


	// Use this for initialization
	void Awake () 
	{
		_navMeshAgent = GetComponent<NavMeshAgent> ();
		_endPointObj = GameObject.FindGameObjectWithTag ("EndPoint");
	}

	// Update is called once per frame
	void Update () {
		_navMeshAgent.SetDestination (_endPointObj.transform.position);
		transform.LookAt (_endPointObj.transform.position);
	}
}
