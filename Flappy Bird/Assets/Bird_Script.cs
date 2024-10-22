using System.Collections;
using System.Collections.Generic;
using UnityEngine;
 
public class Bird_Script : MonoBehaviour
{
    //Rigidbody2D applies 2D physics to a component i.e mass, makes the gameobject get affected by gravity etc. (along x-y plane)
    public Rigidbody2D myRigidbody;
    public float flapStrength;
    public LogicScript logic;
    public bool birdIsAlive = true;

    // Start is called before the first frame update
    void Start()
    {
        // GetComonent<xyz>() refers to the the component 'xyz' inside a game object
        // FindGameObjectWithTag("xyz") gets the first Game Object listed with the Tag "xyz"
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();
    }
 
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && birdIsAlive)
        {
            //Vector1 = Vector on x-axis i.e i vector
            //Vector2 = Vector on y-axis i.e j vector
            //Vector3 = Vector on z-axis i.e k vector

            //Gives a positive upwards velocity to the gameObject
            myRigidbody.velocity = Vector2.up * flapStrength;
        }
    }

    //This function gets called whenever the collider of the gameobject (which this script is a part of) gets triggered 
    private void OnCollisionEnter2D(Collision2D collision)
    {
        logic.gameOver();
        birdIsAlive = false;
    }
}