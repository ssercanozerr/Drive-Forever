using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarSpawnerScript : MonoBehaviour
{
    public GameObject npccar;
    private bool can_spawn = true;
    void Start()
    {
        StartCoroutine(Wait());   
    }
    IEnumerator Wait()
    {
        while (can_spawn == true)
        {
            Instantiate(npccar, transform.position, Quaternion.identity);
            yield return new WaitForSeconds(1f);
        }
    }
}
