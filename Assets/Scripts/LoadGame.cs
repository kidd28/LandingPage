using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI; 
using UnityEngine.EventSystems;


public class LoadGame : MonoBehaviour
{
  private void OnMouseDown()
    {
       SceneManager.LoadScene("LoadGameUi");
         print("clicked");
    }
 
}
