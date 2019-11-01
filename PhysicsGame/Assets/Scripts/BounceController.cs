using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BounceController : MonoBehaviour
{
   
    private float moveSpeed=1;
    public float fx=0;
    public float fy=50;
    public float fz=0;
    private float fX=0; 
    private float fY=50;
    private float fZ=0;
    // Update is called once per frame
    void FixedUpdate()
    {
        
        if(transform.position.y>-0.7){
            moveSpeed=-1;
            // fY=-50;
        }
        else if(transform.position.y<-1){
            // fY=50;
            moveSpeed=1;
        }
        // GetComponent<Rigidbody>().AddForce(fX,fY,fZ);
        transform.Translate (new Vector3(0,Time.deltaTime * moveSpeed,Time.deltaTime * moveSpeed));
        if(Input.GetKeyDown(KeyCode.Space)){
            // GetComponent<Rigidbody>().AddForce(fx,fy,fz);
            // transform.Translate (new Vector3(0,Time.deltaTime * moveSpeed,Time.deltaTime * moveSpeed));

            Debug.Log("space");
        }
    }
}
