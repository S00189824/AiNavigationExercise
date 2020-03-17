using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AIPathFollower : NavMeshMover
{
    public PathNode currentNode;

    // Start is called before the first frame update
    public override void Start()
    {
        base.Start();
        MoveToPathNode();
        
    }

    public void MoveToPathNode()
    {
        if (currentNode != null)
            MoveTo(currentNode.gameObject);
    }

   

    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("PathNode"))
        {
            PathNode node = other.gameObject.GetComponent<PathNode>();
            if(node != null && other.gameObject.name == currentNode.name)
            {
                currentNode = node.NextPath;
                MoveToPathNode();
            }
        }
    }
}
