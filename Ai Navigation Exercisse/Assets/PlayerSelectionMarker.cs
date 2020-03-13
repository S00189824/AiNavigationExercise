using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSelectionMarker : MonoBehaviour
{
    public GameObject SelectionMarkerPrefab;
    public Vector3 Offset = new Vector3(0, 0.1f, 0);

	// Use this for initialization
	void Start ()
    {
        GetComponent<PlayerMovementRayCast>().RayCastReady += PlayerSelectionMarker_RayCastReady;
	}

    private void PlayerSelectionMarker_RayCastReady(RaycastHit selectionData)
    {
        SelectionMarkerPrefab.transform.position = selectionData.point + Offset;
    }

    // Update is called once per frame
    void Update ()
    {
		
	}
}
