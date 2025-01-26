using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManage : MonoBehaviour
{
    public Text scoreText;
    private float Score;
    // Update is called once per frame
    void Update()
    {
        if(GameObject.FindGameObjectWithTag("Player") != null)
        {
            Score += 1 * Time.deltaTime;
            scoreText.text = ((int)Score).ToString();
        }
    }
}
