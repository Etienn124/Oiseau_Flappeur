using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Score : MonoBehaviour
{
    public static int myScore = 0;
    
    private void Start()
    {
        myScore = 0;
    }

    public void Update()
    {
        GetComponent<UnityEngine.UI.Text>().text = myScore.ToString();
    }
}
