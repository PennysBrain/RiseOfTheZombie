using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadSceneClickButton : MonoBehaviour
{
    public void LoadSceneOnClick(int sceneNumber)
    {
        SceneManager.LoadScene(sceneNumber);
    }

    public void LoadSceneOnClick(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }
}
