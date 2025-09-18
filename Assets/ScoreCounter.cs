using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreCounter : MonoBehaviour
{
    [Header("Dynamic")]
    public int score = 0;
    private Text uiText;
    void start()
    {
        uiText = GetComponent<Text>();
    }
    void update()
    {
        uiText.text = score.ToString("#,0");
    }
}
