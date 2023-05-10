using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour
{
   
    [SerializeField] string mainMenuScene = "Start Screen";

    

    

    

  

    public void ReturnToMainMenu()
    {
        
        Cursor.visible = true;
        SceneManager.LoadScene(mainMenuScene);
    }


   

    public void QuitGame()
    {
        Debug.Log("Quit Game");
        Application.Quit();
    }





}
