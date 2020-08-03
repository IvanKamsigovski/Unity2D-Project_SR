using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Core : MonoBehaviour
{
    public int maxHelth;
    public int currentHelth;

    public ExplosionBar explosionBar;

    void Start()
    {
        explosionBar.SetMaxBar(maxHelth);
    }

    private void Update()
    {
        explosionBar.SetBar(currentHelth);
    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "Asteroid")
        {
            currentHelth += 1;
            if (currentHelth == maxHelth)
            {
                Debug.Log("Mrtav");
            }
        }
    }
}
