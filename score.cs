using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class score : MonoBehaviour
{
    // Start is called before the first frame update
    public Text scorerightText;
    public Text scoreleftText;
    int scoreRight = 0;
    int scoreLeft = 0;

    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.name == "Square(1)")
        {
            scoreLeft++;
            scoreleftText.text = scoreLeft.ToString();
        }
        if (col.gameObject.name == "Square")
        {
            scoreRight++;
            scorerightText.text = scoreRight.ToString();

        }
    }
}
