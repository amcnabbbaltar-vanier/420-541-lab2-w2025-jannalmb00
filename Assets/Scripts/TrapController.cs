using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrapController : MonoBehaviour
{
    // Start is called before the first frame update
    public float rotationSpeed = 100f;
    private Rigidbody rb;
    void Start()
    {
        rb = GetComponent<Rigidbody>();    
    }

    // Update is called once per frame
    // void Update()
    // {
    //     transform.Rotate(0, rotationSpeed * Time.deltaTime, 0);   
    // }

    void FixedUpdate()
    {
        Quaternion deltaRotation = Quaternion.Euler(0, rotationSpeed * Time.fixedDeltaTime, 0);
        rb.MoveRotation(rb.rotation * deltaRotation);
    }

}
