using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;
using UnityEngine.SceneManagement;
using UnityEditor;


[DefaultExecutionOrder(1000)]




public class MainMenu : MonoBehaviour
{
    public static MainMenu instance;
    [SerializeField] Text PlayerNameInput;

     public void SetPlayerName()
    {
        Handler.Instance.PlayerName = PlayerNameInput.text;
    }




    // Function to start the game
    public void StartGame()
    {
        // Load the game scene
        SceneManager.LoadScene(1);
    }


    public void Exit()
    {
        EditorApplication.ExitPlaymode();
        Application.Quit(); // original code to quit Unity player

    }
}