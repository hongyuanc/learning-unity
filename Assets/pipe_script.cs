using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pipe_script : MonoBehaviour
{
    public float moveSpeed = 5;
    public float interval = 2;
    private float timer = 0;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.position += (Vector3.left * moveSpeed) * Time.deltaTime;
    }
}