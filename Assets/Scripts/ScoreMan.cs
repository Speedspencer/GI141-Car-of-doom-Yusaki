using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ScoreMan : MonoBehaviour

{

    public Text scoretext;
    public float score = 0;
    public GameObject WinText;
    public reload reloadd;
    public int winscore;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        score += Time.deltaTime;

        scoretext.text = "Score : " + (int)score;

        if (score >= winscore)
        {
            WinText.SetActive(true);
            reloadd.win();
        }

    }

    



}
