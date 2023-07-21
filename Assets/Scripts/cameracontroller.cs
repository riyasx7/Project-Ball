using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameracontroller : MonoBehaviour
{
    public GameObject target;
    
    void Start()
    {
        

    }

    // Update is called once per frame
    void Update()
    {
       
      
      transform.position = new Vector3(transform.position.x,transform.position.y,target.transform.position.z-2f);
      
      
    }
}
