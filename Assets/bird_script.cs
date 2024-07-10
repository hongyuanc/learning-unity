using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bird_script : MonoBehaviour
{
    public Rigidbody2D body;
    public logic_manager logic_Manager;
    public Animator animator;
    public AudioSource audioSource;
    public AudioClip wing, die, hit;

    public float scale = 5;
    public bool status = true;
    private bool soundPlayed = false;
    public float birdDeadZone = 4f;

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
            audioSource.PlayOneShot(wing);
            animator.SetTrigger("Flap");
        }

        if ((transform.position.y > birdDeadZone || transform.position.y < -birdDeadZone) && status)
        {
            status = false;
            gameOver();
            audioSource.PlayOneShot(die);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (status)
        {
            status = false;
            audioSource.PlayOneShot(hit);
            gameOver();
            PlayDeathSound();
        }
    }

    private void PlayDeathSound()
    {
        if (!soundPlayed)
        {
            audioSource.PlayOneShot(die);
            soundPlayed = true;
        }
    }

    private void gameOver()
    {
        logic_Manager.gameOver();
    }
}
