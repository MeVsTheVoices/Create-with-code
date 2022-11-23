using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] prefabs;

    public int animalIndex;

    public float spawnRangeX = 20.0f;

    public float startDelay = 2.0f;

    public float spawnInterval = 2.0f;
    public float spawnIntervalRandomness = 1.5f;
    // Start is called before the first frame update
    void Start()
    {
        Invoke("invokeRandomInterval", startDelay);
    }

    // Update is called once per frame
    void Update()
    {

    }

    void invokeRandomInterval() {
        Invoke("spawnAnimal", 
                spawnInterval + Random.Range(-1.0f, 1.0f) * spawnIntervalRandomness);
    }

    void spawnAnimal() {
        animalIndex = Random.Range(0, prefabs.Length);
        Instantiate(
                prefabs[animalIndex], 
                new Vector3(Random.Range(-spawnRangeX, spawnRangeX) + transform.position.x, 
                            transform.position.y, transform.position.z),
                prefabs[animalIndex].transform.rotation);
        invokeRandomInterval();
    }
}
