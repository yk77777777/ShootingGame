using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GUIStyle scoreStyle;
    public GUIStyle msgStyle;
    // private int score = 0;
    public int Score {get; set;}
    //private string msg = "";
    public string Msg {get; set;}

    // Update is called once per frame
    void Update()
    {
        if (Msg == "GameOver")
        {
            Time.timeScale = 0f;
        }
    }

    void OnGUI() {
        GUI.Label (new Rect (5, 5, 10, 10), Score.ToString(), scoreStyle);
        GUI.Label (new Rect (Screen.width/2-150, Screen.height/2-25, 300, 50), Msg, msgStyle);
    }

    // public int GetScore(){
    //     return score;
    // }
    // public void SetScore(int score){
    //     this.score = score;
    // }
    // public string GetMsg(){
    //     return msg;
    // }
    // public void SetMsg(string msg){
    //     this.msg = msg;
    // }
}
