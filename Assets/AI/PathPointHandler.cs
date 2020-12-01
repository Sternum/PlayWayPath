using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class PathPointHandler : MonoBehaviour, IPathPointHandler
{
    private List<IPathPoint> _pathPoints;
    private int _currentPoint = 0;

    private void Awake()
    {
        _pathPoints = new List<IPathPoint>(FindObjectsOfType<PathPoint>().ToList());
    }

    public Vector3 GetNextPoint()
    {
        IPathPoint point = _pathPoints[_currentPoint++];
        if (_currentPoint >= _pathPoints.Count)
        {
            _currentPoint = 0;
        }
        return point.GetPoint();
    }
}
