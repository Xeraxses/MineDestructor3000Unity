using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class menu : MonoBehaviour
{

    public void PlayGame(){
        SceneManager.LoadScene(1); //lance la scene "jeu" (devra etre renommé plaine)
    }

    public void QuitGame(){
        Application.Quit();
    }


    
}
