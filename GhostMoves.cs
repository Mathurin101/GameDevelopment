using UnityEngine;

public class GhostMoves : MonoBehaviour
{

    //Box-man gameibject
    public GameObject BoxMan;

    //if the ghost runs into this game object
    //public GameObject obstacles;

    public GameObject Ghost;

    //Checking Directions 
    public GameObject SensorForward;
    public GameObject SensorBack;
    public GameObject SensorLeft;
    public GameObject SensorRight;
   

    //checking if the Ghost is alive
    bool IsGhostAlive = true;

    // Update is called once per frame
    void Update()
    {
        //looping while the ghost is alive
        do {

            if (BoxMan.GetComponent<Collider>()) {
                IsGhostAlive = false;
                
            }

            //if the object doesn't collide with anything infornt of them then....
            if (!(SensorForward.GetComponent<Collider>()) || SensorLeft.GetComponent<Collider>() || SensorRight.GetComponent<Collider>())
            {

                //-then move forward
                //created a vector3 that will move in the "y" position
                Vector3 AiMovement = new Vector3(-10, 0, 0);

                //make transform.position:Ghost move to "AiMovement" to position
                Ghost.transform.position += AiMovement * Time.deltaTime;


                //if the object doesn't collide with anything to the left of them then....
            }
            else if (!(SensorLeft.GetComponent<Collider>()) || SensorForward.GetComponent<Collider>() || SensorRight.GetComponent<Collider>())
            {

                //-then move left
                //created a vector3 that will move in the "X" position
                Vector3 AiMovement = new Vector3(0, 0, +10);

                //make transform.position:Ghost move to "AiMovement" to position
                Ghost.transform.position += AiMovement * Time.deltaTime;

                //if the object doesn't collide with anything to the right of them then....
            }
            else if (!(SensorRight.GetComponent<Collider>()))
            {
                //-then move right
                //created a vector3 that will move in the "X" position
                Vector3 AiMovement = new Vector3(0, 0, -10);

                //make transform.position:Ghost move to "AiMovement" to position
                Ghost.transform.position += AiMovement * Time.deltaTime;


                //if the object doesn't collide with anything behind them then....
            }
            else
            {

                //move back
                //created a vector3 that will move in the "y" position
                //Vector3 AiMovement = new Vector3(+10, 0, 0);

                //make transform.position:Ghost move to "AiMovement" to position
                //transform.position += AiMovement * Time.deltaTime;
            }

        } while (IsGhostAlive); 
    }

    //when something collides
    void ONTriggerEnter(Collider collider)
    {
        
        
       
    }
}
