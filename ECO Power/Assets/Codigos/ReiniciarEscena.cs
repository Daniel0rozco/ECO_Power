using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ReiniciarEscena : MonoBehaviour 
{

  void OnTriggerEnter(Collider other)  
  {
      if(other.tag == "Player")    
      {
           SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);   
      }
  }

}