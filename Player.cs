using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : Character
{
    public Movement movement;
    public StaminaBar instance;
    public ScoreManagement scoreManagement;
    Rigidbody2D myrigidbody;
    Animator anim;
    public int stamina = 2;

   

    void Start()
    {
        anim = GetComponent<Animator>();
       
        instance = GetComponent<StaminaBar>();

        myrigidbody = GetComponent<Rigidbody2D>();

        
    }

    public void LogicRun()
    {
        if (movement.speedMove <= 0f)
        {
          movement.speedMove = 0f;
            anim.SetFloat("run",movement.speedMove);
        }

        anim.SetFloat("run",movement.speedMove);

        myrigidbody.velocity = new Vector2(movement.speedMove, 0f);
    }



    void Update()
    {
        Movement();

    }

    public void SpeedUp()
    {
        
        movement.speedMove += 1;
        UseStamina(stamina);
    }

    public override void UseStamina(int stamina)
    {
        instance.UseStamina(1);
    }

    public override void Movement()
    {
        LogicRun();
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.CompareTag("Finish"))
        {
            print("finish");
            scoreManagement.setScore(10);

        }

    }
}
