using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShooting : MonoBehaviour
{
    public Transform firePoint;
    public AudioClip playershootingsfx;
    public GameObject bulletprefab;

    public float bulletForce = 20f;


    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Shoot();
        }
    }

    void Shoot()
    {
        Debug.Log("Pew");
        AudioManager.Instance.PlaySFX(playershootingsfx, 3.0f);
        GameObject bullet = Instantiate(bulletprefab, firePoint.position, firePoint.rotation);
        Rigidbody2D rb = bullet.GetComponent<Rigidbody2D>();
        rb.AddForce(firePoint.up * bulletForce, ForceMode2D.Impulse);

    }
}
