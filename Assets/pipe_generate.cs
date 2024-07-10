using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class pipe_generate : MonoBehaviour
{

    public GameObject pipe;
    public static float interval = 1.5f;
    public float rate = 0.5f;
    public float max_speed = 1;
    private float timer = 0;

    // Start is called before the first frame update
    void Start()
    {
        generate();
        interval = 1.5f;
    }

    // Update is called once per frame
    void Update()
    {
        if (timer < interval)
        {
            timer += Time.deltaTime;
        }
        else
        {
            generate ();
            timer = 0;

            if (interval >= max_speed)
            {
                interval -= 0.025f;
            }

            Debug.Log(interval.ToString());
        }
    }

    void generate()
    {
        float lowest = transform.position.y - 2;
        float highest = transform.position.y + 2.5f;

        Instantiate(pipe, new Vector3(transform.position.x, Random.Range(lowest, highest), 0), transform.rotation);
    }
}
