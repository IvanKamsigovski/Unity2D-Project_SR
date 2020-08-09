using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class PowerUps : MonoBehaviour
{
    public SpriteRenderer rend;
    public Sprite[] spritesArr;


    private void Update()
    {
        if(Input.GetKey(KeyCode.Space))
        {
            rend.sprite = spritesArr[1];
        }
    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        if(col.gameObject.tag == "Player")
        {
            // int rand = Random.Range(0, 1);
            //Reverse(col);
            Freez();
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
}
