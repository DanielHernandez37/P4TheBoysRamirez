using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject[] zombiePrefabs;
    private float spwanRangeX = 20;
    private float spwanRangeZ = 20;
    private float rightSpawnX = 25;
    private float rightSpawnZS = 15.0f;
    private float rightSpawnZE = 2.0f;


    void Start()
    {
        InvokeRepeating("SpanRandomZombie", 2 , 2f);
    }

    // Update is called once per frame
    void Update()
    {



    }
    private void SpanRandomZombie()
    {
        
        int zombieIndex = Random.Range(0, zombiePrefabs.Length);
        Vector3 spawnPos = new Vector3(Random.Range(-spwanRangeX, spwanRangeX), 0, spwanRangeZ);
        Instantiate(zombiePrefabs[zombieIndex], spawnPos, zombiePrefabs[zombieIndex].transform.rotation);
        
        Vector3 spawnPosRight = new Vector3(-rightSpawnX, 0, Random.Range(rightSpawnZS, rightSpawnZE));
        Instantiate(zombiePrefabs[zombieIndex], spawnPosRight, zombiePrefabs[zombieIndex].transform.rotation = Quaternion.Euler(0,90,0));
        
        zombiePrefabs[zombieIndex].transform.rotation = Quaternion.Euler(0, 270, 0);

        Vector3 spawnPosleft = new Vector3(rightSpawnX, 0, Random.Range(rightSpawnZS, rightSpawnZE));
        Instantiate(zombiePrefabs[zombieIndex], spawnPosleft, zombiePrefabs[zombieIndex].transform.rotation);
       
        zombiePrefabs[zombieIndex].transform.rotation = Quaternion.Euler(0, 180, 0);
    }
} 