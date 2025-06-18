using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public int MoveSpeed = 1;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Get the User's Horizontal Inputs with Input.GetKey("type the direction"): Left/right
        if (Input.GetKey("left") || Input.GetKey("right") || Input.GetKey("a") || Input.GetKey("d")) {

            //created a vector3 and take the User Input for the "x": Input.GetAxis("Horizontal")
            Vector3 UserMovement = new Vector3(0, 0, Input.GetAxis("Horizontal"));

            //make transform.position:player move to "UserMovement" to position
            transform.position += UserMovement * MoveSpeed * Time.deltaTime;


        //Get the User's Vertical Inputs with Input.GetKey("type the direction"): up
        } else if (Input.GetKey("up") || Input.GetKey("w")) {

            //created a vector3 and take the User Input for the "y" (Input.GetAxis("Vertical") position
            Vector3 UserMovement = new Vector3( - Input.GetAxis("Vertical"), 0, 0);

            //make transform.position:player move to "UserMovement" to position
            transform.position += UserMovement * MoveSpeed * Time.deltaTime;
            
        }//Get the User's Vertical Inputs with Input.GetKey("type the direction"): down
        else if (Input.GetKey("down") || Input.GetKey("s"))
        {

            //created a vector3 and take the User Input for the "y" (Input.GetAxis("Vertical") position
            Vector3 UserMovement = new Vector3( - Input.GetAxis("Vertical"), 0, 0);

            //make transform.position:player move to "UserMovement" to position
            transform.position += UserMovement * MoveSpeed * Time.deltaTime;
        }
        
    }
}
    

        //player movement without it separated
        //created a vector3 and take the User Input for the "x": Input.GetAxis("Horizontal") position and "y" (Input.GetAxis("Vertical") position
        //Vector3 UserMovement = new Vector3(Input.GetAxis("Horizontal"), 0 , Input.GetAxis("Vertical"));
        
        //make transform.position:player move to "UserMovement" to position
        //transform.position += UserMovement * MoveSpeed * Time.deltaTime;