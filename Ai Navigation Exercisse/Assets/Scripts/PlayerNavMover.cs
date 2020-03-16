using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class PlayerNavMover : NavMeshMover
{

    public GameObject PlayerController;

    public Color DebugLineColor = Color.green;


    // Use this for initialization
    public override void Start()
    {
        PlayerController.GetComponent<PlayerMovementRayCast>().RayCastReady += PlayerNavMover_RayCastReady;
        base.Start();
	}

    private void PlayerNavMover_RayCastReady(RaycastHit selectionData)
    {
        MoveTo(selectionData.point);
    }


    private void OnDrawGizmos()
    {
        if(agent != null)
        {
            if(agent.pathStatus != NavMeshPathStatus.PathInvalid)
            {
                for (int i = 0; i < agent.path.corners.Length; i++)
                {
                    if(i + 1 < agent.path.corners.Length)
                    {
                        Gizmos.color = DebugLineColor;
                        Gizmos.DrawLine(agent.path.corners[i], agent.path.corners[i + 1]);
                    }
                }
            }
        }
    }
}
