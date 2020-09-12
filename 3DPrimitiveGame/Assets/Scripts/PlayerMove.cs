using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerMove : MonoBehaviour
{
    [SerializeField] private GameObject border1;
    [SerializeField] private GameObject border2;
    private float distanceBtwBorders;
    private float step;

    private float offset;
    private float convertSliderValue;


    [SerializeField] private Slider slider;

    private const float DOUBLE_BLOCK_X_SIZE = 4;
    private void Start()
    {
        distanceBtwBorders = Vector3.Distance(border1.transform.position,border2.transform.position)- DOUBLE_BLOCK_X_SIZE;
        step = distanceBtwBorders  / 10;
    }

 
    private void Update()
    {
        convertSliderValue = slider.value-0.5f;
        offset = 10*convertSliderValue* step;                
        transform.position = new Vector3(0+offset,transform.position.y,transform.position.z);
        
    }
}
