using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI; 
using UnityEngine.EventSystems;

public class Back : MonoBehaviour
{
     public void OnButtonClick()
    {
         SceneManager.LoadScene("Example 1");
    }
 
}
