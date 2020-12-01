using UnityEngine;

public interface IPathPointHandler
{
    Vector3 GetNextPoint();
    int PathCount();
}