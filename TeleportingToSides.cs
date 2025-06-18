using UnityEngine;

public class TeleportingToSides : MonoBehaviour
{
    //Teleport to the Oposite box
    public GameObject OtherSideOfBox;

    //added the player to go the said sides
    public GameObject Player;

    public GameObject BoxChecker;

    void Update()
     {
        
     }


    //When something collides with the box
    private void OnTriggerEnter(Collider collider){
        
        //"GetComponent<Collider>()": refers to the object the script it attached to 
        if(GetComponent<Collider>()){

            //OtherSideOfBox.GetComponent<Collider>().isTrigger
            //GameObject "Name" . ---
            //---.GetComponent<"access the inspector by the name">() ---
            // ---."name of the individual thing like "isTrigger"
            //OtherSideOfBox.GetComponent<Collider>().isTrigger = false;

            //Make the Player teleport to the box's position -- causes the box to teleport to eachother constantly
            //Player.transform.position = OtherSideOfBox.transform.position;

            //Make the Player teleport to the BoxChecker's position
            Player.transform.position = BoxChecker.transform.position;
                
        }    
        
        
    }
}

    // // Start is called once before the first execution of Update after the MonoBehaviour is created
    // void Start()
    // {
        
    // }

    // // Update is called once per frame
    // void Update()
    // {
        
    // }