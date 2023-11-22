using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float movementSpeed;
    public float horizontalSpeed;
    float horizontal;
    
    void Update()
    {
        horizontal = Input.GetAxis("Horizontal");
        transform.Translate(new Vector3(horizontal*horizontalSpeed*Time.deltaTime, 0 , movementSpeed*Time.deltaTime));
    }
}
