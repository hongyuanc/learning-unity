using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bird_script : MonoBehaviour
{
    public Rigidbody2D body;
    public float scale = 5;
    public logic_manager logic_Manager;
    public bool status = true;
    public float birdDeadZone = 3.7f;
    public Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        logic_Manager = GameObject.FindGameObjectWithTag("Logic").GetComponent<logic_manager>();
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Space) && status)
        {
            body.velocity = Vector2.up * scale;
            animator.SetTrigger("Flap");
        }

        if (transform.position.y > birdDeadZone || transform.position.y < -1 * birdDeadZone)
        {
            status = false;
            logic_Manager.gameOver();
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        status = false;
        logic_Manager.gameOver();
    }
}
