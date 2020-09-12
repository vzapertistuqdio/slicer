using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RayCaster : MonoBehaviour
{
    [SerializeField] private GameObject particlePrefab;
    private GameObject particle;

    private Ray ray;
    private RaycastHit hit;
    private void Start()
    {
        
    }

   
    private void Update()
    {
        if (Input.GetMouseButton(0))
        {
            RaycastHit hitInfo = new RaycastHit();
            bool hit = Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out hitInfo);
            if (hit)
            {
                particle = Instantiate(particlePrefab) as GameObject;
                particle.transform.position=hitInfo.point;
                if(hitInfo.collider.gameObject.GetComponent<Fruit>()!=null)
                {

                    hitInfo.collider.gameObject.GetComponent<Fruit>().Die();
                }
            }           
        }
    }
}
