using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class player : MonoBehaviour
{

    public GameObject Sphere;
    public static bool game=true;


    public  void OnCollisionEnter(Collision col)    
    {
        if(col.gameObject.name == "Cube")
        {
            Destroy(Sphere.gameObject);
            game =false;
            
        }
        if(game==false)
        {
            
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
            game = true;
            
        }
        
        if(col.gameObject.name == "finish")
        {
           
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 2);
            game = true;
            
        }
        
        
        
    }
}
