using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;


public class PathPointHandler : MonoBehaviour, IPathPointHandler
{
    [SerializeField] 
    private PathPoint _pointPrefab;
    [SerializeField]
    private List<PathPoint> _pathPoints;
    private int _currentPointIndex = 0;

    public event PointAdded OnPointAdd;
    
    public Vector3 GetNextPoint()
    {
        IPathPoint point = _pathPoints[_currentPointIndex++];
        if (_currentPointIndex >= _pathPoints.Count)
        {
            _currentPointIndex = 0;
        }

        return point.GetPoint();
    }

    public int PathCount()
    {
        return _pathPoints.Count;
    }

    

    public void AddPoint(Transform position)
    {
        PathPoint newPoint = Instantiate(_pointPrefab, position);
        _pathPoints.Add(newPoint);
        OnPointAdd?.Invoke();
    }
   
}
