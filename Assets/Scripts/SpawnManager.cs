using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    [SerializeField] private GameObject[] animalPrefabs;
    private readonly float m_ZSpawnPosition = 20;
    private readonly float m_SpawnInterval = 1.5f;
    private readonly float m_StartDelay = 2.0f;


    // Start is called before the first frame update
    private void Start()
    {
        InvokeRepeating(nameof(SpawnRandomAnimal), m_StartDelay, m_SpawnInterval);
    }

    // Update is called once per frame
    private void Update()
    {
    }

    private void SpawnRandomAnimal()
    {
        var animalIndex = Random.Range(0, animalPrefabs.Length);
        var xRange = Random.Range(-14, 14);
        var spawnPosition = new Vector3(xRange, 0, m_ZSpawnPosition);

        Instantiate(animalPrefabs[animalIndex], spawnPosition, animalPrefabs[animalIndex].transform.rotation);
    }
}