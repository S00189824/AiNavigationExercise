using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PatrolToFollow : NavMeshMover
{
    public PathNode currentNode;
    public string tagToTrack = "Player";
    GameObject trackedPlayer;
    public float TrackingDistance = 4;

    // Start is called before the first frame update
    public override void Start()
    {
        trackedPlayer = GameObject.FindGameObjectWithTag(tagToTrack);
        base.Start();
        MoveToPathNode();
        
    }

    public void MoveToPathNode()
    {
        if (currentNode != null)
            MoveTo(currentNode.gameObject);
    }

    void Update()
    {
        if (trackedPlayer != null)
        {
            if (Vector3.Distance(transform.position, trackedPlayer.transform.position) <= TrackingDistance)
            {
                Resume();
                MoveTo(trackedPlayer);
            }
            else
            {
                MoveToPathNode();
            }
        }
    }



    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("PathNode"))
        {
            PathNode node = other.gameObject.GetComponent<PathNode>();
            if (node != null && other.gameObject.name == currentNode.name)
            {
                currentNode = node.NextPath;
                MoveToPathNode();
            }
        }
    }
}
