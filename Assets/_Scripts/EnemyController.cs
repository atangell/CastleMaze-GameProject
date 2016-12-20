using UnityEngine;
using System.Collections;

public class EnemyController : MonoBehaviour {

	// PUBLIC INSTANCE VARIABLES
	public NavMeshAgent Agent;

	// PRIVATE INSTANCE VARIABLES
	private Transform player;

	// Use this for initialization
	void Start () {
		this.player = GameObject.FindWithTag ("Player").transform;
        foreach (GameObject playerLoaded in player)
        {
            Agent = playerLoaded.GetComponent<NavMeshAgent>();
        }
    }
	
	// Update is called once per frame
	void Update () {
		this.Agent.SetDestination (this.player.position);
	}
}
