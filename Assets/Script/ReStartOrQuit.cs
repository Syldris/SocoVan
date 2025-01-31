using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class ReStartOrQuit : MonoBehaviour
{
    public void GameQuit()
    {
        Application.Quit();
    }
    public void GameReStart()
    {
        SceneManager.LoadScene(0);
    }
}
