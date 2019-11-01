using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoatetController : MonoBehaviour
{
    private int rotateSpeed=20;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Debug.Log("x:"+transform.rotation.x);
        if(transform.rotation.x>0.45){
            
            rotateSpeed=-20;
        }
        else if(transform.rotation.x<-0.45){
            rotateSpeed=20;
        }
        transform.Rotate (new Vector3( Time.deltaTime * rotateSpeed,0, 0));

    }
}
