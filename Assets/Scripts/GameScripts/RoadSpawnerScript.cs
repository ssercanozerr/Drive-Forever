using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class RoadSpawnerScript : MonoBehaviour
{
    public GameObject road;
    private bool isRoadSpawn = false;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "maincar" && isRoadSpawn == false)
        {
            Vector3 spawnLocation = new Vector3(transform.position.x, transform.position.y + 10, 0);
            Instantiate(road, spawnLocation, Quaternion.identity);
            isRoadSpawn = true;
            ScoreScript.score += 10;
            Destroy(this.gameObject, 6f);
        }        
    }
}
