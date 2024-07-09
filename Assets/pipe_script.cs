using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pipe_script : MonoBehaviour
{
    public float moveSpeed = 5;
    public float deadZone = -9;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.position += (Vector3.left * moveSpeed) * Time.deltaTime;

        if (transform.position.x < deadZone)
        {
            Debug.Log("Pipe deleted");
            Destroy(gameObject);
        }
    }
}
