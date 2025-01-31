using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Gamemanager : MonoBehaviour
{
    public int sceneBuildIndex;

    public int sceneCount = 5;

    public GameObject winUI;

    public ItemBox[] itemBoxs;

    public bool isGameOver;

    private void Start()
    {
        isGameOver = false;

        sceneBuildIndex = SceneManager.GetActiveScene().buildIndex;
    }
    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            int sceneBuildIndex;
            sceneBuildIndex = SceneManager.GetActiveScene().buildIndex;

            if (isGameOver == true && sceneBuildIndex < sceneCount)
            {
                SceneManager.LoadScene(sceneBuildIndex + 1);
            }
            else
            {
                SceneManager.LoadScene(sceneBuildIndex);
            }
        }

        if(Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
        }

        if (isGameOver == true)
            return;
        int count = 0;
        for(int i = 0; i<itemBoxs.Length; i++)
        {
            if(itemBoxs[i].isOveraped == true)
            {
                count++;
            }
        }

        if(count >= itemBoxs.Length)
        {
            isGameOver = true;
            if(sceneCount == sceneBuildIndex)
            {
                SceneManager.LoadScene(sceneBuildIndex + 1);
            }
            else
            {
                winUI.SetActive(true);
            }
        }
    }
}
