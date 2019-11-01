using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BasketballController : MonoBehaviour
{
    public Text time;
    private int timeCounter;
    public float fx=0;
    public float fy=0;
    public float fz=200;
    void FixedUpdate(){ 
        timeCounter++;
        time.text = "Time: "+string.Format("{0:D2}:{1:D2}:{2:D2}", timeCounter / 3600, (timeCounter / 60)%60,timeCounter %60);
        if(Input.GetKeyDown(KeyCode.RightArrow)){
            GetComponent<Rigidbody>().AddForce(fx,0,fz);
        }
        if(Input.GetKeyDown(KeyCode.LeftArrow)){
            GetComponent<Rigidbody>().AddForce(fx,0,-fz);
        }
        if(Input.GetKeyDown(KeyCode.UpArrow)){
            GetComponent<Rigidbody>().AddForce(fx,fy,0);
        }
        if(transform.position.y<-10f){
            timeCounter=0;
            transform.SetPositionAndRotation(new Vector3(0,3,-3),new Quaternion(0,0,0,0));
        }
    }
}
