using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameStatus : MonoBehaviour
{
    public static int score;
    //static var score:int;
    public TextMeshProUGUI countText;

    void Start()
    {
        score = 0;
    }

    // Update is called once per frame
    void Update()
    {
        countText.text = "# " + score.ToString();
    }

}
