using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlimeGenerator : MonoBehaviour
{
    public Slime slime;
    // Start is called before the first frame update
    void Start()
    {
        slime.Name = "スラきち";
        slime.Hp = 100;
        slime.showInfo();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0)){
            slime.Hp++;
            //slime.SetHp(slime.GetHp()+1); //Javaで書くとこうなる
            slime.showInfo();
        }
    }
}
