using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class PowerUps : MonoBehaviour
{

    private void OnTriggerEnter2D(Collider2D col)
    {
        if(col.gameObject.tag == "Player")
        {
             int randomPowerUp = Random.Range(0, 2);
            switch (randomPowerUp)
            {
                case 0:
                    {
                        Reverse(col);
                    }
                    break;
                case 1:
                    {
                        Freez();
                    }
                    break;
                case 2:
                    {
                        AddHeat();
                    }
                    break;
                default:
                    Freez();
                    break;
            }
        }
    }

    void Reverse(Collider2D player)
    {
        Player charachter = player.GetComponent<Player>();
        charachter.rotatinonDirection = -1;

        Destroy(gameObject);
    }

    void Freez()
    {
        Core.AddHelth(1);
        Destroy(gameObject);
    }

    void AddHeat()
    {
        Core.RemoveHelth(1);
        Destroy(gameObject);
    }
}
