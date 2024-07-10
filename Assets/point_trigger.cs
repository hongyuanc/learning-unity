using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class point_trigger : MonoBehaviour
{
    public logic_manager logic_Manager;
    public pipe_generate pipe;
    public AudioSource audioSource;
    public AudioClip point;

    // Start is called before the first frame update
    void Start()
    {
        logic_Manager = GameObject.FindGameObjectWithTag("Logic").GetComponent<logic_manager>();
        audioSource = gameObject.AddComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.layer == 3)
        {
            if (pipe_generate.interval > 1.2f) 
            {
                logic_Manager.addScore(1);
            } else if (pipe_generate.interval > 1)
            {
                logic_Manager.addScore(2);
            } else if (pipe_generate.interval <= 1)
            {
                logic_Manager.addScore(3);
            }
            
        }
        audioSource.PlayOneShot(point);
       
    }
}
