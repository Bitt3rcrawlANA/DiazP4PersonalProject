using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyCtrl : MonoBehaviour
{

    private float speed = 5.0f;
    private Rigidbody enemyRb;

    public float xRange = 20;
    public float zRange = 20;
    // Start is called before the first frame update
    void Start()
    {
        enemyRb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        enemyRb.AddForce(Vector3.forward * speed);
        enemyRb.AddForce(Vector3.right * speed);

        if (transform.position.x < -xRange)
        {
            Destroy(gameObject);
        }
        if (transform.position.x > xRange)
        {
            Destroy(gameObject);
        }

        if (transform.position.z < -zRange)
        {
            Destroy(gameObject);
        }
        if (transform.position.z > zRange)
        {
            Destroy(gameObject);
        }
    }
}
