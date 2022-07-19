using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetActivEnemy : MonoBehaviour
{
    public GameObject enemy;
    void Start()
    {
        enemy.SetActive(true);
    }

    private void OnTriggerEnter2D(Collider2D stop)
    {
        if (stop.gameObject.name == "Ball")
        {
            enemy.SetActive(false);
        }
    }
}
