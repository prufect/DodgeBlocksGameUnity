﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockSpawner : MonoBehaviour
{
    public Transform[] spawnPoints;
    public GameObject blockPrefab;
    public float timeBetweenWaves = 1f;

    private float timeToSpawn = 2f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time >= timeToSpawn) {
            spawnBlocks();
            timeToSpawn = Time.time + timeBetweenWaves;
        }
    }

    void spawnBlocks() {
        int randomIndex = Random.Range(0, spawnPoints.Length);

        for (int i = 0; i < spawnPoints.Length; i++) {
            if (randomIndex == i) continue;
            Instantiate(blockPrefab, spawnPoints[i].position, Quaternion.identity); 
        }
    }
}
