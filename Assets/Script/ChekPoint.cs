using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChekPoint : MonoBehaviour
{
    [SerializeField] GameObject player; 
    [SerializeField] List < GameObject> CP;
    Vector3 spawnPoint;
    public AudioSource collectSound;


    void Start()
    {
        spawnPoint = gameObject.transform.position;
    }
    void Update()
    {
        if(gameObject.transform.position.y < -10f)
        {
            gameObject.transform.position = spawnPoint;
            Ball.kecepatan = 0;
            //Time.timeScale = 0;
        }
        if (Input.GetKeyDown(KeyCode.W))
        {
            Ball.kecepatan = 10;
        }
    }
    private void OnCollisionEnter(Collision kena)
    {
        if (kena.gameObject.CompareTag("cekPoint"))
        {
            spawnPoint = player.transform.position;
            collectSound.Play();
            Destroy(kena.collider.gameObject, 0.1f);
            
        }
    }
   
}
