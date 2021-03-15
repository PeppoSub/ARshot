using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnScript : MonoBehaviour
{

    public Transform[] spawnPoints;
    public GameObject[] baloons;
    public int WaitTimeSeconds = 2;
    public float shift = 1f;

    private System.Random rand = new System.Random();

    void Start()
    {
        StartCoroutine(StartSpawning());
    }

    IEnumerator StartSpawning()
    {
        yield return new WaitForSeconds(WaitTimeSeconds);

        Vector3 randomSpawn = spawnPoints[0].position;
        int randInt = rand.Next(100);
        float randFloat = (float)randInt / 100f;
        float randomShift = 2f * randFloat - 1f;
        randomSpawn.x = randomShift * shift;

        //Instantiate(baloons[0], spawnPoints[0].position, Quaternion.identity);
        Instantiate(baloons[0], randomSpawn, Quaternion.identity);
        StartCoroutine(StartSpawning());
    }

}
