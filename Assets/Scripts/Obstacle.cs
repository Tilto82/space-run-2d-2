using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour
{
    public GameObject otherGameObject;
    private ObstacleSpawn obstacleSpawn;

    private void Update()
    {
        obstacleSpawn = otherGameObject.GetComponent<ObstacleSpawn>();
    }

}
