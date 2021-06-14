using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms;

public class SpawnManager : MonoBehaviour
{

    [SerializeField] private GameObject[] animalPrefabs;
    private float m_ZSpawnPosition = 20;
  
   
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.S))
        {
           SpawnRandomAnimal();
        }
    }

    void SpawnRandomAnimal()
    {
        int animalIndex = Random.Range(0, animalPrefabs.Length);
        int xRange = Random.Range(-14, 14);
        Vector3 spawnPosition = new Vector3(xRange, 0, m_ZSpawnPosition);
            
        Instantiate(animalPrefabs[animalIndex], spawnPosition, animalPrefabs[animalIndex].transform.rotation);
    }
}
