using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndGame : MonoBehaviour
{
    public GameObject winnerText;
    public int seconds = 5;
    // Start is called before the first frame update
    void Start()
    {
        winnerText.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        winnerText.SetActive(true);
        StartCoroutine(YouWin(seconds));
    }

    IEnumerator YouWin(int seconds)
    {
        yield return new WaitForSeconds(seconds);
        //load next scene
        Debug.Log("End of game");
        SceneManager.LoadScene("MainMenu");
    }
}
