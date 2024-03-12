using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlusOneScript : MonoBehaviour
{
    public LogicScript logic;
    public BirdScript bird;

    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();
        bird = GameObject.FindGameObjectWithTag("Bird").GetComponent<BirdScript>();
    }

    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {

        if(collision.gameObject.layer == 3 && bird.isBirdAlive)
        {
        logic.addScore(1);
        }
    }
}
