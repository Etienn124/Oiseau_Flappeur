using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UImanager : MonoBehaviour
{
    public GameObject gameOverPanel;
    public GameObject newGamePanel;

    private void Start()
    {
        gameOverPanel.gameObject.SetActive(false);
        newGamePanel.gameObject.SetActive(false);
    }

    public void RelaunchObject()
    {
        gameOverPanel.gameObject.SetActive(false);
        newGamePanel.gameObject.SetActive(false);
    }

    public void triggerGameOver()
    {
        gameOverPanel.gameObject.SetActive(true);

    }
}
