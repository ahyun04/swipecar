using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameDirector : MonoBehaviour
{
    private float startTime;
    public Text text;

    void Start()
    {
        text.text = "게임이 시작되었습니다!";
    }

    

    public void UpdateUI(float distance)
    {
        text.text = $"{distance}m";
    }
}
