using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    public float bound = 30.0f;

    public Vector3 initialPosition;
    // Start is called before the first frame update
    void Start()
    {
        initialPosition = transform.position;   
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x > initialPosition.x + bound  ||
            transform.position.x < initialPosition.x - bound  ||
            transform.position.y > initialPosition.y + bound  ||
            transform.position.y < initialPosition.y - bound  ||
            transform.position.z > initialPosition.z + bound  ||
            transform.position.z < initialPosition.z - bound) {
                Destroy(gameObject);
            }
    }
}
