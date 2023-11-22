using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraCodes : MonoBehaviour
{
    public Transform targetTransform;
    public Vector3 offset;
   
    
    private void LateUpdate()
    {

        transform.position = Vector3.Lerp(transform.position, targetTransform.position + offset, Time.deltaTime*2);
    }
}
