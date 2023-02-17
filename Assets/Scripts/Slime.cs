using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Slime : MonoBehaviour
{
    //string name;
    //int hp;

    public string Name {get; set;}
    public int Hp {get; set;} = 0;
    
    // public string Name{
    //     get{
    //         return name;
    //     }
    //     set{
    //         name = value;
    //     }
    // }

    // public int Hp{
    //     get{
    //         return hp;
    //     }
    //     set{
    //         hp = value;
    //     }
    // }
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void showInfo(){
        Debug.Log($"{Name}(hp:{Hp})");
    }
}
