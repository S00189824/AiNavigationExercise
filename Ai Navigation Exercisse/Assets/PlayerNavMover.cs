using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class PlayerNavMover : NavMeshMover
{

    public GameObject PlayerController;
    

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


    
}
