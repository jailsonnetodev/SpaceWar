using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;
using UnityEngine.SceneManagement;
public class ButtonFuctions : MonoBehaviour
{
    public void Quit(){
        Application.Quit();
    }

    public void Start(){
        PlayerPrefs.SetInt("Score", 0);
        SceneManager.LoadScene(1);
    }
}
