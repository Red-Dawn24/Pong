using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static int PlayerScore1 = 0;
    public static int PlayerScore2 = 0;
    public GUISkin layout;
    GameObject theBall;
     void Start()
    {
        theBall = GameObject.FindGameObjectWithTag("Ball");
    }
    public static void Score (string wallID)
    {
        if(wallID == "Right Wall")
        {
            PlayerScore1++;
        }
        else
        {
            PlayerScore2++;
        }
    }
    private void OnGUI()
    {
        GUI.skin = layout;
        GUI.Label(new Rect(Screen.width / 2 - 150 - 12, 20, 100, 100), "" + PlayerScore1);
        GUI.Label(new Rect(Screen.width / 2 + 150 + 12, 20, 100, 100), "" + PlayerScore2);
    }
}
