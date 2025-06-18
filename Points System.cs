using UnityEngine;

public class PointsSystem : MonoBehaviour
{
    //the character that will collect the orbs
    public GameObject PacMan;

    //To help keep track of the points
    public GameObject TheOrb;


    //subscribing: almost like extending from the parent class "MainPointSystem"
    //creating an "Instance"(which is the name used in the other class) 
    private void Awake()
    {
        //The way to extend from another class
        MainPointSystem.OnCountingBalls += OnDestroy;
    }

    //Close off the extension or unsubscribing with the "-="  when the GameObject is destroyed
    //OnDestroy(): is an actually method that does something... 
    //...denpending what YOU put int the method body
    private void OnDestroy()
    {
             MainPointSystem.OnCountingBalls -= OnDestroy;
    }
   
   //OnTriggerEnter(Collider collider): is an actually method that...
   //...does collision in the game
    void OnTriggerEnter(Collider collider){
       
       //when this GameObject that is attached...
       //...collides with the PacMan GameObject
        if(PacMan.GetComponent<Collider>()){

           //Call the "BallDestroyedCount()": which will increament the NumberOfBalls by 10
            MainPointSystem.BallDestroyedCount();
            
            //destroy that specific orb
            Destroy(TheOrb);
        }

    }
}
