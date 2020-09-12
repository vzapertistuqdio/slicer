using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaneMove : MonoBehaviour
{
    
    private void Start()
    {
        
    }

    
    private void Update()
    {
        if (Input.GetMouseButton(0))
        {
            RaycastHit hitInfo = new RaycastHit();
            bool hit = Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out hitInfo);
            transform.position = new Vector3(hitInfo.point.x, transform.position.y, transform.position.z);
        }
    }
}
