using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public void RelaunchGame()
    {
        Player _player = FindObjectOfType<Player>();
        checkpoint[] _checkpoints = FindObjectsOfType<checkpoint>();
        pipe[] _pipe = FindObjectsOfType<pipe>();
        UImanager _UI = FindObjectOfType<UImanager>();


        //on va relancer tout les checkpoints
        foreach (checkpoint item in _checkpoints)
        {
            item.RelaunchObject();
        }

        // on relance tout les tuyaux
        foreach (pipe item in _pipe)
        {
            item.RelaunchObject();
        }

        //on relance le player
        _player.RelaunchObject();
        _player.gameObject.SetActive(true);

        //on désactive l'écran de game over
        _UI.RelaunchObject();



    }

}
