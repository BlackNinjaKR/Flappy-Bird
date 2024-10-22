using System.Collections;
using System.Collections.Generic;
using UnityEngine;
 
public class Pipe_Move_Script : MonoBehaviour
{
    public float moveSpeed = 5;
    public float deadZone = -50;
 
    // Start is called before the first frame update
    void Start()
    {
        
    }
 
    // Update is called once per frame
    void Update()
    {
        //Time.deltaTime keeps the program consistent with respect of relative time
        //Otherwise the script will depend on the no. of times Update() is called
        //Update() is called upon every frame. 

        transform.position = transform.position + (Vector3.left * moveSpeed) * Time.deltaTime;
        if (transform.position.x < deadZone)
        {
            //Helps with memory collection otherwise the gameobjects will keep building up and will take up more memory as the game progresses.
            Destroy(gameObject);
        }
    }
}