using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CylinderController : MonoBehaviour
{
    private float rotateSpeed=20;
    void Update(){ 
        transform.Rotate(new Vector3(Time.deltaTime*rotateSpeed,0,0));
    }
}
