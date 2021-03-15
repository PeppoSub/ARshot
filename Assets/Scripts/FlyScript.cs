using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlyScript : MonoBehaviour
{
    public float FlySpeed = 0.5f;
    public float maxHi = 10f;
 
    public GameObject smoke;

    void Update()
    {
        transform.Translate(Vector3.up * Time.deltaTime * FlySpeed);

        if(transform.position.y > maxHi)
        {
            Destroy(gameObject);
        }
    }

    void OnCollisionEnter(Collision col)
    {
        //if (col.gameObject.tag == "projectile(Clone)") {
     
        Destroy(gameObject);
        Instantiate(smoke, gameObject.transform.position, Quaternion.identity);
        Destroy(gameObject);

        GameStatus.score++;
    }

}
