using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kardus : MonoBehaviour
{
    private void OnCollisionEnter(Collision kardus)
    {
        if (kardus.gameObject.name == "miring1")
        {
            Destroy(gameObject);
        }
    }
}
