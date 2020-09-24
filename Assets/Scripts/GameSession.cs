using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameSession : MonoBehaviour
{
    [SerializeField] int scoreValue = 100;
   [SerializeField]  int Score=0; //Serialized for debug...



    // Start is called before the first frame update
    void Awake()
    {
        SetUpSingleton();
    }

    private void SetUpSingleton()
    {
        if (FindObjectsOfType(GetType()).Length > 1)
        {
            Destroy(gameObject);
        }
        else
        {
            DontDestroyOnLoad(gameObject);
        }
    }

    public int GetScore()
    {
        return Score;
    }
    public void AddScore()
    {
        Score += scoreValue;
    }
    public void ResetGame()
    {
        Destroy(gameObject);
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
