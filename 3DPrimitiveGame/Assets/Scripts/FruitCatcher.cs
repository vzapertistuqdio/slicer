using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class FruitCatcher : MonoBehaviour
{
    [SerializeField] private GameObject addScoreText;

    public UnityEvent OnCatched;
    
   private  void Start()
    {
        addScoreText.SetActive(false);
    }

 
    private void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
       
        if (other.gameObject.GetComponent<FruitPart>()!=null)
        {
            addScoreText.SetActive(false);
            StartCoroutine(UseAnim());
            Score.GetInstance().Increase(1);
            Debug.Log(Score.GetInstance().Get());
            Destroy(other.gameObject);
        }
    }

    private IEnumerator UseAnim()
    {
    
        addScoreText.SetActive(true);
        yield return new WaitForSeconds(0.8f);
        addScoreText.SetActive(false);
    }
}
