using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public delegate void PlayerRayCastReady(RaycastHit selectionData);
public class PlayerRayCast : MonoBehaviour
{

    protected RaycastHit raycastHit;
    protected Ray ray;
    public LayerMask layerMask;

    public event PlayerRayCastReady RayCastReady;
    public string InputAxis = "Fire1";

	// Update is called once per frame
	public virtual void Update ()
    {
		if(Input.GetButton(InputAxis))
        {              

            ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            if(Physics.Raycast(ray,out raycastHit,Mathf.Infinity,layerMask))
            {


                if (RayCastReady != null)
                    RayCastReady(raycastHit);
            }
        }
	}
}
