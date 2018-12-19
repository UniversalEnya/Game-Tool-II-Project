using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class NextLevel : MonoBehaviour
{

    public int LevelToLoad;

    private void OnTriggerEnter(Collider Player)
    {
        SceneManager.LoadScene(LevelToLoad);
    }
}
