using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class S_Move : MonoBehaviour
{
    // Start is called before the first frame update
    public float movePower = 1f;
    public float jumpPower = 3f;

    Vector3 Vt3;
    Rigidbody2D rd;
    


    void Start()
    {
        rd = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        Move();
        Jump();
    }

    void Jump()
    {



    }
    void Move()
    {
        Vector3 Move = Vector3.zero;
        if (Input.GetAxis("Horizontal") < 0)
        {
            Move = Vector3.left;
        }
        else if (Input.GetAxis("Horizontal") > 0)
        {
            Move = Vector3.right;
        }
        if (Input.GetAxis("Vertical") > 0)
        {
            Move = Vector3.up;
        }
        else if (Input.GetAxis("Vertical") < 0)
        {
            Move = Vector3.down;
        }

        transform.position += Move * movePower * Time.deltaTime;
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("Enter");
    }
    private void OnCollisionStay2D(Collision2D collision)
    {
        Debug.Log("stay");
    }
    private void OnCollisionExit2D(Collision2D collision)
    {
        Debug.Log("Exit");
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("Enter");
    }
    private void OnTriggerStay2D(Collider2D collision)
    {
        Debug.Log("stay");
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        Debug.Log("Exit");
    }

}
