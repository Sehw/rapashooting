using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SaveScore()
    {
        PlayerPrefs.SetInt("score", currentScore);
        print("저장 완료됐습니다.");
    }

}
