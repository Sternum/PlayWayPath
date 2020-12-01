using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PathPoint : MonoBehaviour, IPathPoint
{
    public Vector3 GetPoint()
    {
        return this.transform.position;
    }
    
}
