using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{
    public Transform shotPoint;
    public GameObject bulletPrefab;
    public float timeBetweenShots;
    private float startTimeBetweenShots;

    public GameObject bullet;

    private float bulletForce = 20f;
    public AudioSource shootAudio;

    void Update()
    {
        timeBetweenShots -= Time.deltaTime;
    }

    public void Shoot()
    {
        bullet = Instantiate(bulletPrefab, shotPoint.position, shotPoint.rotation);

        bullet.layer = 6;

        Rigidbody2D rb = bullet.GetComponent<Rigidbody2D>();

        rb.AddForce(shotPoint.up * bulletForce, ForceMode2D.Impulse);

        timeBetweenShots = startTimeBetweenShots;

        shootAudio.Play();
    }

}

//BRUH