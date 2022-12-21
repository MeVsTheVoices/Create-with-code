using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Target : MonoBehaviour
{
    private Rigidbody targetRb;
    // Start is called before the first frame update
    private float upwardsForceMinimum = 14;
    private float upwardsForceMaximum = 18;

    private float torqueMinimum = -10;
    private float torqueMaximum = 10;

    private float xRange = 4;
    private float ySpawnPos = -3;
    void Start()
    {
        targetRb = GetComponent<Rigidbody>();
        targetRb.AddForce(Vector3.up * Random.Range(upwardsForceMinimum, upwardsForceMaximum) * (targetRb.mass), ForceMode.Impulse);
        targetRb.AddTorque(
            Random.Range(torqueMinimum, torqueMaximum), Random.RandomRange(torqueMinimum, torqueMaximum),
            Random.Range(torqueMinimum, torqueMaximum), ForceMode.Impulse);
        transform.position = new Vector3(Random.Range(-xRange, xRange), ySpawnPos);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnMouseDown() {
        Destroy(gameObject);
    }

    private void OnTriggerEnter(Collider other) {
        Destroy(gameObject);
    }
}
