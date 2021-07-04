using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleSpawn : MonoBehaviour
{

    public GameObject obstacle;

    private float maxX = 4.5f;
    private float minX = 0.5f;

    private float timeBetweenSpawn = 1.5f;
    private float spawnTime;

    public GameObject obstacleCopy;

    private UI ui;
    public GameObject otherGameObject;


    void Update()
    {
        ui = otherGameObject.GetComponent<UI>();

        if (Time.time > spawnTime)
        {
            if (GameObject.FindGameObjectWithTag("Player") != null)
            {
                if (ui.canStart == true)
                {
                    Spawn();
                    spawnTime = Time.time + timeBetweenSpawn;
                }
            }
        }  
    }

    void Spawn()
    {
        float randomX = Random.Range(minX, maxX);

        obstacleCopy = Instantiate(obstacle, transform.position + new Vector3(randomX, 4, 0), transform.rotation);
        Destroy(obstacleCopy, 5f);
    }


}
