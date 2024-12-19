using Unity.Hierarchy;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public Transform target;
    public float speed = 3f;
    public float rotateSpeed;
    private Rigidbody2D rb;
    public float distanceBetween;
    private float distance;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        //Get Target
        if (!target)
        {
            FindTarget();
        }else
        {
            //Rotate
            Rotate();
        }
        //check the distance
        distance = Vector2.Distance(transform.position, target.transform.position);
        if(distance < distanceBetween)
        {
            transform.position = Vector2.MoveTowards(this.transform.position, target.transform.position, speed * Time.deltaTime);
        }
    }

    private void FixedUpdate()
    {
        //Move
        rb.linearVelocity = transform.up * speed;
    }

    private void Rotate()
    {
        Vector2 targetDirection = target.position - transform.position;
        float angle = Mathf.Atan2(targetDirection.y, targetDirection.x) * Mathf.Rad2Deg - 90f;
        Quaternion q = Quaternion.Euler(new Vector3(0, 0, angle));
        transform.localRotation = Quaternion.Slerp(transform.localRotation, q, rotateSpeed);
    }

    private void FindTarget ()
    {
        target = GameObject.FindGameObjectWithTag("Player").transform;
    }
}
