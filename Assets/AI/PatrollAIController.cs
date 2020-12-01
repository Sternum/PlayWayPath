using UnityEngine;
using UnityEngine.AI;


[RequireComponent(typeof(NavMeshAgent))]
public class PatrollAIController : MonoBehaviour
{
    private NavMeshAgent _agent;
    private IPathPointHandler _pathPointHandler;
    
    private void Awake()
    {
        _agent = GetComponent<NavMeshAgent>();
        _pathPointHandler = GetComponent<IPathPointHandler>();
        enabled = _pathPointHandler.PathCount() > 0 ?  true : false;
    }

    private void Start()
    {
        if (enabled)
        {
            GoToNextPoint();
        }
    }

    private void GoToNextPoint()
    {
        _agent.SetDestination(_pathPointHandler.GetNextPoint());
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
