using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    private readonly float topBound = 30f;
    private readonly float lowerBound = -10f;

    // Start is called before the first frame update
    private void Start()
    {
    }

    // Update is called once per frame
    private void Update()
    {
        if (transform.position.z > topBound)
            Destroy(gameObject);
        else if (transform.position.z < lowerBound) Destroy(gameObject);
    }
}