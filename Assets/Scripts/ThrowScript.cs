using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ThrowScript : MonoBehaviour
{
    public GameObject arCamera;
    public TextMeshProUGUI countText;
    public GameObject throwFrom;
    public Rigidbody ball;
    public int thrust = 25;

    public void Throw()
    {
        // Instantiate the projectile at the position and rotation of this transform
        Rigidbody clone;
        clone = Instantiate(ball, throwFrom.transform.position, Quaternion.identity);

        // Give the cloned object an initial velocity
        clone.velocity = transform.TransformDirection(arCamera.transform.forward * thrust);
        //rball.AddForce(arCamera.transform.forward * thrust);
    }

}
