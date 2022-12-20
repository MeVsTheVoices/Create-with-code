using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpinPropeller : MonoBehaviour
{
    public float rotationSpeed;
    public Vector3 rotationUnitVector = Vector3.fwd;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void FixedUpdate() {
        transform.Rotate(rotationUnitVector * rotationSpeed * Time.deltaTime);
    }
}
