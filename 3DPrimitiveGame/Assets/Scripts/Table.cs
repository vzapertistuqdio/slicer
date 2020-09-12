using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Table : MonoBehaviour
{
    [SerializeField] private ParticleSystem smoke;
    #region MonoBehavior
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    #endregion

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.GetComponent<Fruit>() != null || other.gameObject.GetComponent<FruitPart>()!=null)
        {
            smoke.transform.position = other.transform.position;
            smoke.Play();
            Destroy(other.gameObject);
        }

    }
}
