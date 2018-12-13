using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;


public class MoveTo2 : MonoBehaviour {

    public Transform[] goal;
    int currentGoal;
    NavMeshAgent agent;
    private Transform crawler;
    private float speed = 4f;

    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        GetTarget();

    }
    void Update()
    {
        if (Vector3.Distance(goal[currentGoal].position, transform.position) < 2f)
        {
            GetTarget();
        }
    }

    void GetTarget()
    {
        currentGoal = Random.Range(0, goal.Length);
        agent.destination = goal[currentGoal].position;

    }
}
