using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coin : MonoBehaviour
{
    public AudioSource collectSound;
    private void OnTriggerEnter(Collider coin)
    {
        if (coin.gameObject.name == "Ball")
        {
            collectSound.Play();
            scoring.score += 100;
            Destroy(gameObject);
        }
    }
}
