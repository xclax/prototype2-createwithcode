using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private float m_HorizontalInput;
    private readonly float m_XRange = 10.0f;
    [SerializeField] private GameObject projectilePrefab;
    [SerializeField] private float speed = 10.0f;

    // Start is called before the first frame update
    private void Start()
    {
    }

    // Update is called once per frame
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)) Instantiate(projectilePrefab, transform.position, Quaternion.identity);
        if (transform.position.x < -m_XRange)
            transform.position = new Vector3(-m_XRange, transform.position.y, transform.position.z);
        if (transform.position.x > m_XRange)
            transform.position = new Vector3(m_XRange, transform.position.y, transform.position.z);

        m_HorizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * (m_HorizontalInput * Time.deltaTime * speed));
    }
}