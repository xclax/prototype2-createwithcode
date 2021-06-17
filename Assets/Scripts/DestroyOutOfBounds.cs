using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    private readonly float topBound = 30f;
    private readonly float lowerBound = -10f;
    private readonly float rightBound = 20f;
    private GameManager m_GameManager;

    // Start is called before the first frame update
    private void Start()
    {
        m_GameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
    }

    // Update is called once per frame
    private void Update()
    {
        if (transform.position.z > topBound)
        {
            Destroy(gameObject);
        }
        else if (transform.position.z < lowerBound)
        {
            m_GameManager.AddLives(-1);
            Destroy(gameObject);
        }
        else if (transform.position.x > rightBound)
        {
            m_GameManager.AddLives(-1);
            Destroy(gameObject);
        }

      
    }
}