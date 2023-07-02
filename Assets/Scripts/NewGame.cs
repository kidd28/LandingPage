using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI; 



public class NewGame : MonoBehaviour
{
   public void GotoNewGame()
    {
       SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1 );
       Debug.Log("hey");
    }
}
