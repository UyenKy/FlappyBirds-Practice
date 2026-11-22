using System.Diagnostics;
using UnityEngine;

public class PipeSpawner : MonoBehaviour
{
    public float timeSpawn = 3f;
    public GameObject pipePrefabs;
    public Transform pipePosition;

    public float stopWatch = 0f;
    // Update is called once per frame
    void Update()
    {
        stopWatch += Time.deltaTime;
        if (stopWatch >= timeSpawn)
        {
            Vector3 spawnPipe = pipePosition.position;
            spawnPipe.y += Random.Range(-2f, 2f);
            Instantiate(pipePrefabs, spawnPipe, Quaternion.identity);
            stopWatch = 0f;
        }
    }
}
