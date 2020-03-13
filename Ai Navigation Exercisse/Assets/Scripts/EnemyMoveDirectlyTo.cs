using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMoveDirectlyTo : NavMeshMover
{
    public string tagToTrack = "Player";
    GameObject trackedPlayer;


    public override void Start()
    {
        trackedPlayer = GameObject.FindGameObjectWithTag(tagToTrack);

        base.Start();
    }

    // Update is called once per frame
    void Update()
    {
        if(trackedPlayer != null)
        {
            MoveTo(trackedPlayer);
        }
    }
}
