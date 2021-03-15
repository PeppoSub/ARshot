using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ShootScript : MonoBehaviour
{
    public GameObject arCamera;
    public GameObject smoke;
    public AudioClip shot;
    public TextMeshProUGUI countText;

    private int score;

    public void Start()
    {
        score = 0;
    }

    public void Shoot()
    {
        //AudioSource.PlayClipAtPoint(shot, new Vector3(0,0,0));

        RaycastHit hit;

        if(Physics.Raycast(arCamera.transform.position, arCamera.transform.forward, out hit))
        {
            if(hit.transform.name == "balloonSkull(Clone)")
            {
                Destroy(hit.transform.gameObject);
                Instantiate(smoke, hit.point, Quaternion.LookRotation(hit.normal));

                score++;
                countText.text = "# " + score.ToString();
            }
        }
    }


}
