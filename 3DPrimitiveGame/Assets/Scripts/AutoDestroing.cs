using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoDestroing : MonoBehaviour
{
   
    private void Start()
    {
        StartCoroutine(DestroyAfterTime());
    }

   
    private void Update()
    {
        
    }
    private IEnumerator DestroyAfterTime()
    {
        yield return new WaitForSeconds(0.5f);
        Destroy(this.gameObject);
    }
}
