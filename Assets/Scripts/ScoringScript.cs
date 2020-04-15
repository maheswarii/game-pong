using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoringScript : MonoBehaviour
{
    public TextMeshProUGUI scoringtextP1, scoringtextP2;
    public static int scoreP1=0, scoreP2=0;
    // Start is called before the first frame update
    void Start()
    {
       scoringtextP1.text = scoreP1.ToString();
       scoringtextP2.text = scoreP2.ToString(); 
    }

    public void UpdateScore(string namaWall){
        if(namaWall == "dindingKiri"){
            scoreP2 += 1;
            scoringtextP2.text = scoreP2.ToString();
        } else if (namaWall == "dindingKanan"){
            scoreP1 += 1;
            scoringtextP1.text = scoreP1.ToString();
        }

     }
    
}
