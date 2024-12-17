using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float MoveSpeed = 10f;

    private Rigidbody2D rb;

    void Start() {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        float moveX = Input.GetAxis("Horizontal") * MoveSpeed;
        float moveZ = Input.GetAxis("Vertical") * MoveSpeed;

        rb.AddForce(new Vector2(moveX, moveZ), ForceMode2D.Force);
    }
}
