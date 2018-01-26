using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class ControlEnemigo : MonoBehaviour {
    public GameObject player;
    public NavMeshAgent agent;
    public Animator anim;

	// Use this for initialization
	void Start () {
        agent = this.GetComponent<NavMeshAgent>();
        anim = this.GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
        agent.SetDestination(player.transform.position);
        float speed = agent.velocity.magnitude;
        anim.SetFloat("speed", speed);
	}
}
