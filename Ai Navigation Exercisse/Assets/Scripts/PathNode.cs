using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PathNode : MonoBehaviour
{

    public PathNode NextPath;

    public Color debugColor = Color.red;

    private void OnDrawGizmos()
    {
        if(NextPath != null)
        {
            Gizmos.color = debugColor;
            Gizmos.DrawLine(transform.position, NextPath.transform.position);

            Vector3 direction = NextPath.transform.position - transform.position;

            Gizmos.color = Color.red;
            Gizmos.DrawLine(transform.position, transform.position + direction * 0.5f);
        }
    }
}
