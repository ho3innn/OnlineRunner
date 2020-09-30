using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[SerializeField]
public abstract class Character :MonoBehaviour
{
   
    
    private int height;
    private int weight;
    private int Gender;
    private int stamina;
    private string characterName="";
    private float moveSpeed;

    public abstract void UseStamina(int stamina);
    public abstract void Movement();
}
