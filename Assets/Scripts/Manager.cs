using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Manager : MonoBehaviour
{

    [SerializeField] float m_PlayerHealth = 200.0f; //amout of health player has
    [SerializeField] int LeveltoLoad; //level selector

    public void DecreaseHealth()
    {
        m_PlayerHealth = m_PlayerHealth - 1f; //This takes away from the player's health value
        CheckHealth();
        Debug.Log(m_PlayerHealth);
    }

    private void CheckHealth()
    {
        if (m_PlayerHealth <= 0)
        {
            GameOver(); //if player's health decreases to 0 player loses
        }
    }

    private void GameOver()
    {
        SceneManager.LoadScene(LeveltoLoad); // when the player loses the loads scene choosen in inspector
    }

}
