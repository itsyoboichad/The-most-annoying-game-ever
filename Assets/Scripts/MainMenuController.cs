using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenuController : MonoBehaviour
{
    public GameObject creditsImg;

    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void StartGame()
    {
        // load game
        SceneManager.LoadScene("SampleScene");
    }

    public void Credits()
    {
        // view credits
        creditsImg.SetActive(true);
    }

    public void QuitGame()
    {
        Application.Quit();
    }

    public void Back()
    {
        creditsImg.SetActive(false);
    }
}
