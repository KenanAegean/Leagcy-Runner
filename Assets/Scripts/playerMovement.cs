using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovement : MonoBehaviour
{



    public Rigidbody rb;
    public float speed = 20.0f;
    public float childSpeed = 3f;
    public float adultSpeed = 5f;
    public float oldSpeed = 2f;

    float horizontalInput;
    //public bool isPw1Taken = false, isPw2Taken = false, isPw3Taken = false;
    
    private void FixedUpdate()
    {
        Vector3 forwardMove = transform.forward * speed * Time.fixedDeltaTime;
        Vector3 horizontalMove = transform.right * horizontalInput * speed * Time.fixedDeltaTime;
        rb.MovePosition(rb.position + forwardMove + horizontalMove);
    }

    // Start is called before the first frame update


    void Start()
    {
        
    }

    // Update is called once per frame
    private void LateUpdate()
    {

        horizontalInput = Input.GetAxis("Horizontal");

       
    }

   

}
