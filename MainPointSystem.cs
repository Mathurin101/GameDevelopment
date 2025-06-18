using System;
using UnityEngine;
using TMPro;


public class MainPointSystem : MonoBehaviour
{
    //Makes this class publicly accessable to all classes with the "static" keyword
    public static MainPointSystem Instance;

    //The name after "Action On..." can be anything of your choosing
    //This will be used as a refernce/link to other classes EX: MainPointSystem.OnCountingBalls += ...
    //This doesn't have to be static because "public static MainPointSystem Instance;" ....
    //...is already static
    public static event Action OnCountingBalls;


    //had to add "public static " in front of "int NumberOfBalls"... 
    //...so it change in another class
    //will count how many points that is collected
    //Made it a short instead of int to save memory for now
    public static short NumberOfBalls = 0;//192 ballz in total

    
    private void Awake()
    {
        Instance = this;
    }

    //OnCountingBalls?.Invoke(): activates the extension of this class 
    public void CountingBalls()
    {
        OnCountingBalls?.Invoke();
    }

    //made a method to increament the counter and print to see if it works
    public static void BallDestroyedCount()
    {
        NumberOfBalls +=10;
        //Debug.Log("Balls: " + NumberOfBalls);// just checking ballz
        
    }

}
