using System.Collections;
using System.Collections.Generic;
using UnityEngine;
 
public class BallMovement : MonoBehaviour
{
   
    public GameObject move;
   
    public UDPReceive udp;
    public Rigidbody Rb;
    public float speed ;
    string z;
    
   
    
    
    
    void Start()
    {
      Rb = move.GetComponent<Rigidbody>(); 
       
    }
 
    // Update is called once per frame
    void Update()
    {

    
        string data = udp.data;
        data = data.Remove(0, 1);
        data = data.Remove(data.Length-1, 1);
        //(255,361,50012) example data (x,y,area)
        string[] info = data.Split(',');

    
        float x = float.Parse(info[0])/100;

        
        float y = -330;
        Rb.AddForce(Vector3.forward * speed * Time.deltaTime);
        transform.position=move.transform.position;
        z = transform.position.ToString();
        z = z.Remove(0,1);
        z = z.Remove(0,2);
        z = z.Remove(z.Length-1,1);
        z = z.Remove(0,3);
        z = z.Remove(0,4);
        z = z.Remove(0,5);
        float m = float.Parse(z);
        float n = m;
        print(x);
        move.transform.localPosition = new Vector3(x, y ,m);
      
         }
   
       
  
   
}