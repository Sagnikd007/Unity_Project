using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controls : MonoBehaviour
{
    Rigidbody Sd;
    // Start is called before the first frame update
    void Start()
    {
       Sd=GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
     if (Input.GetKeyDown("space")){
         Sd.velocity=new Vector3(0,5,0);
     }
     if  (Input.GetKeyDown("up")){
         Sd.velocity=new Vector3(0,0,5);
    }
     if (Input.GetKeyDown("right")){
        Sd.velocity=new Vector3(5,0,0);
     }
     if (Input.GetKeyDown("down")){
        Sd.velocity=new Vector3(0,0,-5);
     }
     if  (Input.GetKeyDown("left")){
        Sd.velocity=new Vector3(-5,0,0);
    }

}
}
