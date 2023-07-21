using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class back : MonoBehaviour
{
   public void rev()
   {
     SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex -1);
   }

   public void rev1()
   {
     SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 2);
   }

}
