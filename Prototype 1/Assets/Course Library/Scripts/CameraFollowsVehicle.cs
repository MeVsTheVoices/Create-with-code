using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollowsVehicle : MonoBehaviour
{
    public Vector3 offset;
    public GameObject followee;
    // Start is called before the first frame update
    void Start()
    {
        offset = followee.transform.position - transform.position;
    }

    // Update is called once per frame
    void LateUpdate()
    {
        transform.position = followee.transform.position - offset;
    }
}
