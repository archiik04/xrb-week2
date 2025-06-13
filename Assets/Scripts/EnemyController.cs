using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyController : MonoBehaviour
{
    [SerializeField] private NavMeshAgent agent;
    [SerializeField] private float threshold = 0.5f;
    [SerializeField] private Transform point1;
    [SerializeField] private Transform point2;
    [SerializeField] private Transform point3;

    private int currentPointIndex = 0;
    private Transform[] points;

    void Start()
    {
        points = new Transform[] { point1, point2, point3 };
        agent.SetDestination(points[currentPointIndex].position);
    }

    void Update()
    {
        if (Vector3.Distance(transform.position, points[currentPointIndex].position) < threshold)
        {
            currentPointIndex = (currentPointIndex + 1) % points.Length;
            agent.SetDestination(points[currentPointIndex].position);
        }
    }
}
