using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

[RequireComponent(typeof(NavMeshAgent))]
public class PatrollAIController : MonoBehaviour
{
    private NavMeshAgent _agent;
    private IPathPointHandler _pathPointHandler;
    private Vector3 _currentDestination;
    
    private void Awake()
    {
        _agent = GetComponent<NavMeshAgent>();
        _pathPointHandler = GetComponent<IPathPointHandler>();
    }

    private void Start()
    {
        GoToNextPoint();
    }

    private void GoToNextPoint()
    {
        _currentDestination = _pathPointHandler.GetNextPoint();
        _agent.SetDestination(_currentDestination);
    }

    private void Update()
    {
        CheckReachedPoint();
    }

    private void CheckReachedPoint()
    {
        if (_agent.remainingDistance <= 0)
        {
            GoToNextPoint();
        }
    }
    
}
