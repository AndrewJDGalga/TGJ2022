using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovement : MonoBehaviour
{
    private bool up, down, left, right;

    [SerializeField] 
    float moveSpeed = 5f;
    [SerializeField]
    private float rotationSpeed;

    private Rigidbody2D rb;
    Vector2 movement;


    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    // Update is called once per frame
    void Update()
    {
        // Input
        if (Input.GetKeyDown(KeyCode.W))
            up = true;
        if (Input.GetKeyDown(KeyCode.S))
            down = true;
        if (Input.GetKeyDown(KeyCode.A))
            left = true;
        if (Input.GetKeyDown(KeyCode.D))
            right = true;

        if (Input.GetKeyUp(KeyCode.W))
            up = false;
        if (Input.GetKeyUp(KeyCode.S))
            down = false;
        if (Input.GetKeyUp(KeyCode.A))
            left = false;
        if (Input.GetKeyUp(KeyCode.D))
            right = false;
    }

    void FixedUpdate()
    {
        // Movement
        float xChange = 0f;
        float yChange = 0f;
        if (up)
            yChange += moveSpeed;
        if (down)
            yChange -= moveSpeed;
        if (left)
            xChange -= moveSpeed;
        if (right)
            xChange += moveSpeed;

        rb.velocity = new Vector2(xChange, yChange);

        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");
        Vector2 moveDirec = new Vector2(horizontalInput, verticalInput);
        moveDirec.Normalize();
        if(moveDirec != Vector2.zero)
        {
            Quaternion toRotation = Quaternion.LookRotation(Vector3.forward, moveDirec);
            transform.rotation = Quaternion.RotateTowards(transform.rotation, toRotation, rotationSpeed * Time.deltaTime);
        }
    }
}
