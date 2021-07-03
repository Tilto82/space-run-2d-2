using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootingTwo : MonoBehaviour
{
    public Transform shotPointTwo;
    public GameObject bulletPrefab;
    public float timeBetweenShots;
    private float startTimeBetweenShots;

    public GameObject bulletTwo;

    private float bulletForce = 20f;

    void Update()
    {
        timeBetweenShots -= Time.deltaTime;
    }

    public void Shoot()
    {
        bulletTwo = Instantiate(bulletPrefab, shotPointTwo.position, shotPointTwo.rotation);

        bulletTwo.layer = 7;

        Rigidbody2D rbTwo = bulletTwo.GetComponent<Rigidbody2D>();

        rbTwo.AddForce(shotPointTwo.up * bulletForce, ForceMode2D.Impulse);

        timeBetweenShots = startTimeBetweenShots;
    }

}