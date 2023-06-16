using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NEWLVL : MonoBehaviour
{

    public BGEnemies bigg;
   void OnTriggerEnter2D(Collider2D other)
   {
        if (bigg.DOOROPEN)
        {
            
            if (other.tag == "Player")
            {
                float pastrezult = RECORDMEME.PEREBOR(RoomMove.getlvl);
                if (pastrezult > RoomMove.gettime || pastrezult == 0 || true)
                {
                    Debug.Log("OK");
                    if (pastrezult > RoomMove.gettime)
                    {
                        RECORDMEME.DEL(RoomMove.getlvl);
                    }
                    RECORDMEME.AddScore();
                    RECORDMEME.SaveScore();
                    Debug.Log("OK " + RoomMove.lvlnum.ToString());
                }
                if (SceneManager.GetActiveScene().buildIndex == 2)
                {
                    PlayerInteractions.Death();
                }
                else
                {
                    SceneManager.LoadScene(2);
                }
            }
        }
   }
}
