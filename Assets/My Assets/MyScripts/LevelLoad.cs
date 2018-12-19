
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelLoad : MonoBehaviour
{

    public int LevelToLoad;

    public void LoadLevel()
    {
        SceneManager.LoadScene(LevelToLoad);
    }
}