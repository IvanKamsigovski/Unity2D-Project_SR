using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    public float speed;

    public float bulletSpeed;
    public Transform bulletPossition;
    public GameObject bullet;
    public Image[] hpImg;

    private float fierRate = 0.5f;
   // private float movement = 0f;
    private bool canShoot = true;

    public int hp = 3;

    void Update()
    {
        //movement = Input.GetAxisRaw("Horizontal");
        if (canShoot)
        {
            StartCoroutine(Shooting());
        }
    }

    private void FixedUpdate()
    {
        Movement();
        HeartsDisplay();
    }

    void Movement()
    {
        if (Input.GetKey(KeyCode.A))
        {
            transform.RotateAround(Vector3.zero, Vector3.forward, Time.deltaTime * -speed);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.RotateAround(Vector3.zero, Vector3.forward, Time.deltaTime * speed);
        }
    }

    IEnumerator Shooting()
    {
        GameObject Bullet = Instantiate(bullet, bulletPossition.transform.position, Quaternion.identity);
        //Bullet.GetComponent<Rigidbody2D>().velocity = -transform.position * bulletSpeed;
        Bullet.GetComponent<Rigidbody2D>().AddForce(bulletPossition.transform.position * -bulletSpeed, ForceMode2D.Impulse);
        Destroy(Bullet, 1.2f);
        canShoot = false;
        yield return new WaitForSeconds(fierRate);
        canShoot = true;
    }

    void HeartsDisplay()
    {
        for (int i = 0; i < hpImg.Length; i++)
        {
            if (i < hp)
            {
                hpImg[i].enabled = true;
            }
            else
            {
                hpImg[i].enabled = false;
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "Asteroid")
        {
            hp -= 1;
            if(hp == 0)
            {
                Debug.Log("Mrtav");
            }
        }
    }

}
