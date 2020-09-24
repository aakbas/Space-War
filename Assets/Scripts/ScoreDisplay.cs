using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ScoreDisplay : MonoBehaviour
{
    [SerializeField] Text scoreText;
    GameSession myGameSession;
    // Start is called before the first frame update
    void Start()
    {
        scoreText = GetComponent<Text>();
        myGameSession = FindObjectOfType<GameSession>();
    }

    // Update is called once per frame
    void Update()
    {
        scoreText.text = myGameSession.GetScore().ToString();
    }
}
