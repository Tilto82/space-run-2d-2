using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    public GameObject player;

    public float playerSpeed = 5;
    public float move;
    private Rigidbody2D rb;
    private Vector2 playerDirection;

    public GameObject gameOver;
    public GameObject scoreText;
    public GameObject shootButton;

    private UI ui;
    public GameObject otherGameObject;
    private Shooting shooting;
    private ShootingTwo shootingTwo;

    public int coinCount;
    public AudioSource coinPickUp;
    public AudioSource hitHurt;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        ui = otherGameObject.GetComponent<UI>();
    }

    public void FixedUpdate()
    {
        if (ui.canStart)
        {
            transform.Translate(transform.right * move * playerSpeed * Time.fixedDeltaTime);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Obstacle")
        {
            hitHurt.Play();
            ui.canStart = false;

            player.SetActive(false);
            
            gameOver.SetActive(true);

            Destroy(collision.gameObject);
        }

        if (collision.gameObject.CompareTag("Coin"))
        {
            coinPickUp.Play();
            coinCount++;
        }
    }
}
