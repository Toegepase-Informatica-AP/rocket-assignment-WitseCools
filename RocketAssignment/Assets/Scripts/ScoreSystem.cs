using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreSystem : MonoBehaviour
{
    public int score = 0;


    private void OnGUI()
    {
        GUI.Label(new Rect(10, 10, 100, 20), "Score : " + score);
    }
}
