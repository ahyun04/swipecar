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
        text.text = "������ ���۵Ǿ����ϴ�!";
    }

    

    public void UpdateUI(float distance)
    {
        text.text = $"{distance}m";
    }
}
