using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Score : MonoBehaviour
{
    private static Score score;
    private int playerScore;
    private Score() { }

    public static Score GetInstance()
    {
        return score;
    }
    private void Awake()
    {
        score = GetComponent<Score>();
    }
    private void Start()
    {
        
    }

    
    void Update()
    {
        
    }

    public void Increase(int value)
    {
        playerScore += value;
    }
    public void Decrease(int value)
    {
        playerScore -= value;
    }
    public void Set(int value)
    {
        playerScore = value;
    }
    public int Get()
    {
        return playerScore;
    }
}
