using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class PowerUps : MonoBehaviour
{

    private void OnTriggerEnter2D(Collider2D col)
    {
        if(col.gameObject.tag == "Player")
        {
            int randFunction = Random.Range(0, 3);
            randomPowerUP(randFunction, col);
        }
    }

    void randomPowerUP(int pov, Collider2D player)
    {
        switch (pov)
        {
            case 0:
                {
                    StartCoroutine( Reverse(player));
                    Debug.Log("Promjena smjera");
                }
                break;
            case 1:
                {
                    Freez();
                    Debug.Log("Smanjena temp");
                }
                break;
            case 2:
                {
                    AddHeat();
                    Debug.Log("Povecan temp");
                }
                break;
            default:
                Freez();
                Debug.Log("Smanjena temp");
                break;
        }
    }

    IEnumerator Reverse(Collider2D player)
    {
        Player charachter = player.GetComponent<Player>();
        charachter.rotatinonDirection = -1;

        GetComponent<SpriteRenderer>().enabled = false;
        GetComponent<BoxCollider2D>().enabled = false;

        yield return new WaitForSeconds(2);
        charachter.rotatinonDirection = 1;
        Destroy(gameObject);
    }

    //Popravit buigc gdje ne rade obe zajedno
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
