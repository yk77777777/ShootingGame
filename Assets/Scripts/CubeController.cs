using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeController : MonoBehaviour
{
    //private GameManager gm;
    public GameManager Gm {get; set;}

    void OnCollisionEnter(Collision coll){
        if (coll.gameObject.tag == "Bullet") {
            // Gm.SetScore (Gm.GetScore () + 1);
            Gm.Score++;
            Destroy (gameObject, 0.1f);
        }
        if (coll.gameObject.tag == "Floor") {
           // Gm.SetMsg ("GameOver");
           Gm.Msg = "GameOver";
        }
    }

    // public void SetGameManager(GameManager gm) {
    //     this.gm = gm;
    // }
}
