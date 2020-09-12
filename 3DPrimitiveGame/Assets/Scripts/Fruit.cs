using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fruit: MonoBehaviour
{
    [SerializeField] private GameObject[] miniSphere;
    private GameObject gameController;
    private RandomSpherGeneartor generator;

    private bool flag = false;
    private float randomAngle;

    [SerializeField] private ParticleSystem dieParticle;

    private GameObject spot;
    private void Awake()
    {
        gameController = GameObject.FindGameObjectWithTag("GameController");
        generator=gameController.GetComponent<RandomSpherGeneartor>();
        for (int i = 0; i < miniSphere.Length; i++)
        {
            miniSphere[i].SetActive(false);
        }
        randomAngle = 0;
    }

    private void Start()
    {
        for(int i=0;i<miniSphere.Length;i++)
        {
            miniSphere[i].SetActive(false);
        }
    }

    private void Update()
    {
        RandomFluctuation();
    }

    public void Die()
    {
        dieParticle.Play();
    
        for (int i = 0; i < miniSphere.Length; i++)
        {
            miniSphere[i].SetActive(true);
            miniSphere[i].transform.parent = null;
        }
        if (!flag)
        {
            generator.CurrentObstacleCount--;
            Score.GetInstance().Increase(1);
            Debug.Log(Score.GetInstance().Get());
            flag = true;
        }
        StartCoroutine(DieAfterTime());

     
    }
    private void RandomFluctuation()
    {
        if(randomAngle==0)
        {
            randomAngle = Random.Range(-0.5f, 0.5f);
        }
        transform.Rotate(0,randomAngle,0);
    }

    private IEnumerator DieAfterTime()
    {
        yield return new WaitForSeconds(0.25f);
        Destroy(this.gameObject);
    }
}
