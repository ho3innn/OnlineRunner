using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{

    Rigidbody2D myrigidbody;
    Animator anim;
    public float speedMove;

    void Start()
    {
        speedMove = .5f;
        
        
        StartCoroutine("lessSpeed");
    }

    // Update is called once per frame
   

    IEnumerator lessSpeed()
    {
        while (true)
        {
            speedMove -= .75f;


            yield return new WaitForSeconds(.25f);

        }
    }
}
