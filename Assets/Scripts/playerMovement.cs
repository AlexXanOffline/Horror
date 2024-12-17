using UnityEngine;

public class playerMovement : MonoBehaviour
{
    [SerializeField]
    private float Speed = 2f;
    private Rigidbody2D = rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    void Update()
    {
        float MoveX = Input.GetAxis("Horizontal");
        float MoveZ = Input.GetAxis("Vertical");
    }
}
