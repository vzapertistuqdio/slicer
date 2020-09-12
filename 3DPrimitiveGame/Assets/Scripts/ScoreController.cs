using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreController : MonoBehaviour
{
    [SerializeField] private Text score;
    private void Start()
    {
        
    }

   
    private void Update()
    {
        score.text = Score.GetInstance().Get().ToString();
    }
}
