using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class show : MonoBehaviour
{
    public int score;

    public TextMeshProUGUI text;

    public void AddScore()
    {
        score++;
        text.text = score.ToString();
    }
}
