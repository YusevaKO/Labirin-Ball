using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyEnemy : MonoBehaviour
{
    private void OnCollisionEnter(Collision hancur)
    {
        if (hancur.collider.CompareTag("enemy"))
        {
            Destroy(hancur.collider.gameObject, 0.3f);
        }
    }
}
