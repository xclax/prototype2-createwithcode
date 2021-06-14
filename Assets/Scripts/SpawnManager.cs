using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms;

public class SpawnManager : MonoBehaviour
{

    [SerializeField] private GameObject[] animalPrefabs;
    private float m_ZSpawnPosition = 20;
    private float m_SpawnInterval = 1.5f;
    private float m_StartDelay = 2.0f;
  
   
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating(nameof(SpawnRandomAnimal), m_StartDelay, m_SpawnInterval);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SpawnRandomAnimal()
    {
        int animalIndex = Random.Range(0, animalPrefabs.Length);
        int xRange = Random.Range(-14, 14);
        Vector3 spawnPosition = new Vector3(xRange, 0, m_ZSpawnPosition);
            
        Instantiate(animalPrefabs[animalIndex], spawnPosition, animalPrefabs[animalIndex].transform.rotation);
    }
}
