using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallScript : MonoBehaviour
{
    public float maxLo = -2f;

    void Update()
    {
        if (transform.position.y < maxLo)
        {
            Destroy(gameObject);
        }
    }

}
