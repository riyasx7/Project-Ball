
/*using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{
  protected bool riyas =false;
  string z;
  public static float con;
   public Rigidbody Rb;
   public GameObject move;
    public float speed;
  
    void Start()
    {
      Rb = move.GetComponent<Rigidbody>(); 
       
    }
   void Update()
    {   
        riyas=false;
        Rb.AddForce(Vector3.forward * speed * Time.deltaTime);
        if(riyas==false)
        {
             transform.position=move.transform.position;
              z = transform.position.ToString();
              z = z.Remove(0,1);
              z = z.Remove(0,2);
              z = z.Remove(z.Length-1,1);
              z = z.Remove(0,3);
              z = z.Remove(0,4);
              z = z.Remove(0,5);
              con = float.Parse(z);
               
             print(con);
        }
        riyas = true;
    }
   
}*/
