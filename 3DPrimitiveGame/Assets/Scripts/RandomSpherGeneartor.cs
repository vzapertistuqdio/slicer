using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using UnityEngine;

public class RandomSpherGeneartor : MonoBehaviour
{
    [SerializeField] private GameObject point1;
    [SerializeField] private GameObject point2;

    [SerializeField] private GameObject[] obstaclePrefabs;
    private float randomXPos;
    private GameObject obstacle;

    private int currentObstacleCount;

    public int CurrentObstacleCount { get => currentObstacleCount; set => currentObstacleCount = value; }

    private void Start()
    {
        InvokeRepeating("SpawnObstacle",1,0.5f);
    }

   
    private void Update()
    {
       
    }

    private void SpawnObstacle()
    {
        obstacle = Instantiate(obstaclePrefabs[Random.Range(0,obstaclePrefabs.Length)]) as GameObject;
        randomXPos = Random.Range(point1.transform.position.x+4,point2.transform.position.x-4);
        obstacle.transform.position = new Vector3(randomXPos,15,2.66f);
        CurrentObstacleCount++;
    }
}
