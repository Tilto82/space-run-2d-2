using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckBullet : MonoBehaviour
{

    public GameObject otherGameObject;
    private Shooting shooting;

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Bullet")
        {
            Destroy(shooting.bullet);
        }
    }

    void Update()
    {
        shooting = otherGameObject.GetComponent<Shooting>();
    }
}
