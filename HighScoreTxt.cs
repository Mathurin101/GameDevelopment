using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class HighScoreTxt : MonoBehaviour
{
    //Will print on the UI/canvas
    public TextMeshProUGUI CurrentScore;

    //subscribing: almost like extending from the parent class "MainPointSystem"
    //creating an "Instance"(which is the name used in the other class) 
    void Awake()
    {
        //The way to extend from another class
        MainPointSystem.OnCountingBalls += ShowingCurrentScoreNUM;
    }

    //Close off the extension or unsubscribing with the "-="  when the GameObject is destroyed
    //OnDestroy(): is an actually method that does something... 
    //...denpending what "YOU" put int the method body
    void OnDestroy()
    {
        MainPointSystem.OnCountingBalls -= ShowingCurrentScoreNUM;
    }

    void Start()
    {
        //CurrentScore = GetComponent<TMP_Text>();
        CurrentScore.text = "High Score: " + 0;
    }
    
    void Update()
    {
        ShowingCurrentScoreNUM();
    }

    public void ShowingCurrentScoreNUM()
    {
        CurrentScore.text = "High Score " + MainPointSystem.NumberOfBalls;
        //Debug.Log("Ballzz: " + MainPointSystem.NumberOfBalls);//just checking the ballz
    }
    

}
// //subscribing: almost like extending from the parent class "MainPointSystem"
//     //creating an "Instance"(which is the name used in the other class) 
//     void Awake()
//     {
//         //The way to extend from another class
//         MainPointSystem.OnCountingBalls += ShowingCurrentScoreNUM;
        
//     }

//     void start()
//     {
//          //CurrentScore = GetComponent<TMP_Text>();
//          CurrentScore.text = "High Score: " + 0; 
//     }

//     void update()
//     {
//         ShowingCurrentScoreNUM();
//     }
    

//     //Close off the extension or unsubscribing with the "-="  when the GameObject is destroyed
//     //OnDestroy(): is an actually method that does something... 
//     //...denpending what "YOU" put int the method body
//     void OnDestroy()
//     {
//         MainPointSystem.OnCountingBalls -= ShowingCurrentScoreNUM;
//     }


//      public void ShowingCurrentScoreNUM()
//      {
//          CurrentScore.text = "High Score: " + MainPointSystem.NumberOfBalls;
//          Debug.Log("Ballzz: " + MainPointSystem.NumberOfBalls);
//      }