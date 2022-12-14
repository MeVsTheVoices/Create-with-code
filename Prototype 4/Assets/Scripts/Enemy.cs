using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{

    public float speed;

    private Rigidbody enemyRb;
    private GameObject player;

    // Start is called before the first frame update
    void Start()
    {
        enemyRb = GetComponent<Rigidbody>();
        player = GameObject.Find("Player");
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y < -10) Destroy(gameObject);
        enemyRb.AddForce((player.transform.position - transform.position).normalized * speed);
    }
}
