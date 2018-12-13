using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;


public class WagonTrail : MonoBehaviour {

    // put the points from unity interface
    public Transform[] goal;

    public int currentWayPoint = 0;
    Transform targetWayPoint;
    public AudioSource sound;

    public float speed = 4f;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        // check if we have somewere to walk
        if (currentWayPoint < this.goal.Length)
        {
            if (targetWayPoint == null)
                targetWayPoint = goal[currentWayPoint];
            walk();
        }
        else
        {
            sound.gameObject.SetActive(false);
        }
    }

    void walk()
    {
        // rotate towards the target
        transform.right = Vector3.RotateTowards(transform.right, targetWayPoint.position - transform.position, speed * Time.deltaTime, 1.0f);

        // move towards the target
        transform.position = Vector3.MoveTowards(transform.position, targetWayPoint.position, speed * Time.deltaTime);

        if (transform.position == targetWayPoint.position)
        {
            currentWayPoint++;
            targetWayPoint = goal[currentWayPoint];
        }
    }
}
