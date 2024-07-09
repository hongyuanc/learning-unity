using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class point_trigger : MonoBehaviour
{
    public logic_manager logic_Manager;

    // Start is called before the first frame update
    void Start()
    {
        logic_Manager = GameObject.FindGameObjectWithTag("Logic").GetComponent<logic_manager>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.layer == 3)
        {
            logic_Manager.addScore(1);
        }
       
    }
}
