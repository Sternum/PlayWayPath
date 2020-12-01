using UnityEngine;

public delegate void PointAdded();

public interface IPathPointHandler
{
    Vector3 GetNextPoint();
    int PathCount();
    
    event PointAdded OnPointAdd;
}