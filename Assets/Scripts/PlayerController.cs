using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private float m_HorizontalInput;
    private float m_VerticalInput;
    private readonly float m_XRange = 14.0f;
    private readonly float m_ZTopBorder = 11.5f;
    private readonly float m_ZLowerBorder = 0.25f;
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

        if (transform.position.z > m_ZTopBorder)
            transform.position = new Vector3(transform.position.x, transform.position.y, m_ZTopBorder);
        if (transform.position.z < m_ZLowerBorder)
            transform.position = new Vector3(transform.position.x, transform.position.y, m_ZLowerBorder);

        m_HorizontalInput = Input.GetAxis("Horizontal");
        m_VerticalInput = Input.GetAxis("Vertical");
        transform.Translate(Vector3.right * (m_HorizontalInput * Time.deltaTime * speed));
        transform.Translate(Vector3.forward * (m_VerticalInput * Time.deltaTime * speed));
    }
}