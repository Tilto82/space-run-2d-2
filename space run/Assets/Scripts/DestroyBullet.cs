using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyBullet : MonoBehaviour
{
    public GameObject otherGameObject;
    private Shooting shooting;

    public GameObject coinPrefab;
    public GameObject coinCopy;

    private GameObject obstacle;
    private Transform obstacleTransform;

    void OnCollisionEnter2D(Collision2D collision)
    {
        Destroy(gameObject);
        if (collision.gameObject.tag == "Bullet")
        {
            Destroy(collision.gameObject);
        }
        
            if (collision.gameObject.tag == "Obstacle")
            {
                obstacle = collision.gameObject;
                obstacleTransform = collision.gameObject.transform;

                Destroy(collision.gameObject);

                coinCopy = Instantiate(coinPrefab, obstacleTransform.position, obstacleTransform.rotation);
                Destroy(coinCopy, 3f);
            }
        
    }

    void Update()
    {
        shooting = otherGameObject.GetComponent<Shooting>();
    }
}
