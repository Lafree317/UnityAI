using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class NewBehaviourScript : MonoBehaviour {

    public Transform findGoal;
    private NavMeshAgent _agent;

	// Use this for initialization
	void Start () {
        _agent = this.GetComponent<NavMeshAgent>();
	}
	
	// Update is called once per frame
	void Update () {
		if(_agent && findGoal) {
            _agent.SetDestination(findGoal.transform.position);
        }
	}
}
