using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy : MonoBehaviour
{
    public GameObject EnemyBall;
    public float waktuMin, waktuMax;
   
    void Start()
    {
        
        StartCoroutine(MunculEnemy());
    }
 

    IEnumerator MunculEnemy()
    {
        Instantiate(EnemyBall, transform.position, Quaternion.identity);
        yield return new WaitForSeconds(Random.Range(waktuMin,waktuMax));
        StartCoroutine(MunculEnemy());
    }

}
