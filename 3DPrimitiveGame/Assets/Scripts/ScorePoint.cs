using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScorePoint : MonoBehaviour
{
    private Score score;
    private const float MIN_X_VALUE= -8.5f;
    private const float MAX_X_VALUE = 8.5f;
    private void Start()
    {
        score = Score.GetInstance();
    }

    
    private void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.GetComponent<PlayerMove>() != null)
        {
            score.Increase(1);
            Debug.Log(score.Get()); ;
            float randomXCoordinate = Random.Range(MIN_X_VALUE, MAX_X_VALUE);
            transform.position = new Vector3(randomXCoordinate, transform.position.y, transform.position.z);
        }
    }
}
