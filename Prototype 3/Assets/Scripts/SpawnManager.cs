using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject obstaclePrefab;
    private Vector3 spawnPos = new Vector3(25, 0, 0);
    // Start is called before the first frame update
    private float startDelay = 2;
    private float repeatRate = 2;

    private PlayerController playerControllerScript;
    void Start()
    {
        playerControllerScript = GameObject.Find("Player").GetComponent<PlayerController>();
        InvokeRepeating("SpawnObstacle", startDelay, repeatRate);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SpawnObstacle() {
        if (playerControllerScript.gameOver == false)
            Instantiate(obstaclePrefab, transform.position + spawnPos, obstaclePrefab.transform.rotation);
    }
}
