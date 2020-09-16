using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneMag : MonoBehaviour
{
    public GameObject nextButton;
    public GameObject exitButton;
    public GameObject restartButton;
    public GameObject lvlClearPanel;
    public GameObject lvlClearText;
    public GameObject lvlFailText;
    private int currentSceneIndex;
    private Scene currentActiveScene;

    // Start is called before the first frame update
    void Start()
    {
        currentActiveScene = SceneManager.GetActiveScene();
        currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
    }

    void Update()
    {
        //if(Input.GetKeyDown(KeyCode.Escape))
        //{
           // pauseGame();
        //}

    }

    //public void pauseGame()
    //{
        //Time.timeScale = 0;
        //lvlClearPanel.SetActive(true);
       // exitButton.SetActive(true);
   // }
    public void nextLevel()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(currentSceneIndex + 1);
    }

    public void quitGame()
    {
        Time.timeScale = 0;
        Application.Quit();
    }

    public void restartGame()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(currentActiveScene.name);
    }

    public void levelFail()
    {
        lvlClearPanel.SetActive(true);
        restartButton.SetActive(true);
        exitButton.SetActive(true);
        lvlFailText.SetActive(true);
    }

    public void levelClear()
    {
        lvlClearPanel.SetActive(true);
        lvlClearText.SetActive(true);
        nextButton.SetActive(true);
        exitButton.SetActive(true);
        restartButton.SetActive(true);
    }

   
}
