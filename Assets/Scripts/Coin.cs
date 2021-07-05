using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    private Animation _animation;
    private BoxCollider2D _boxCollider;

    private void Start()
    {
        _animation = GetComponent<Animation>();
        _boxCollider = GetComponent<BoxCollider2D>();
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            _boxCollider.enabled = false;
            _animation.Play();
            Destroy(gameObject, 1f);
        }
    }

}
