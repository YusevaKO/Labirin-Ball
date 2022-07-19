using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomEnemy : MonoBehaviour
{
    public GameObject EnemyBall;
    public float waktuMin, waktuMax;
    public float posisiMin, PosisiMaks;

    void Start()
    {
        StartCoroutine(MunculEnemy());
    }
    IEnumerator MunculEnemy()
    {
        Instantiate(EnemyBall, transform.position +Vector3.right*Random.Range(posisiMin,PosisiMaks), Quaternion.identity);
        yield return new WaitForSeconds(Random.Range(waktuMin, waktuMax));
        StartCoroutine(MunculEnemy());
    }
   
}
