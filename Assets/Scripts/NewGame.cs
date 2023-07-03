using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI; 
using UnityEngine.EventSystems;


public class NewGame : MonoBehaviour
{
     private void OnMouseDown()
    {
       SceneManager.LoadScene("NewGameUi");
         print("clicked");
    }
 
}
