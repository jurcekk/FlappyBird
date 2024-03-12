using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdScript : MonoBehaviour
{
    public Rigidbody2D body;
    public float flapStrength;
    public LogicScript logic;
    public bool isBirdAlive = true;
    public Animator animator;

    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();
    }

    void Death()
    {
        if(isBirdAlive)
        {
            isBirdAlive = false;
            logic.Fail();
        }
    }

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space) && isBirdAlive)
        {
            animator.SetTrigger("Flap");
            body.velocity = Vector2.up * flapStrength;
            animator.SetTrigger("noFlap");
        }

        if(transform.position.y < -13 || transform.position.y > 14)
        {
           Death();
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Death();
    }
}
