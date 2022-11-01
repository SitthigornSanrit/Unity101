using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Controller : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

        //print.(transform.position);


    }

    // Update is called once per frame
    void Update()
    {

        //print("Hello");
        //print.(transform.position);

        if (Input.GetKeyDown(KeyCode.S))
        {
            //print("S");
            transform.position = new Vector3(0, 0, 0);
        }

        if (Input.GetKeyDown(KeyCode.W))
        {
            //print("W");

            //transform.position = new Vector3(0, 2, 0);
            transform.position = new Vector3(0, transform.position.y + 0.1f, 0);
        }

        if (Input.GetKeyDown(KeyCode.X))
        {
            //print("X");

            //transform.position = new Vector3(0, -2, 0);
            transform.position = new Vector3(0, transform.position.y - 0.1f, 0);
        }

        if (Input.GetKeyDown(KeyCode.A))
        {
            //print("A");

            //transform.position = new Vector3(-2, 0, 0);
            transform.position = new Vector3(transform.position.x - 0.1f, 0, 0);
        }

        if (Input.GetKeyDown(KeyCode.D))
        {
            //print("D");

            //transform.position = new Vector3(2, 0, 0);
            transform.position = new Vector3(transform.position.x + 0.1f, 0, 0);
        }

        if (Input.GetKeyDown(KeyCode.E))
        {
            //print("E");

            transform.position = new Vector3(transform.position.x + 0.1f, transform.position.y + 0.1f, 0);
        }

        if (Input.GetKeyDown(KeyCode.Q))
        {
            //print("Q");

            transform.position = new Vector3(transform.position.x - 0.1f, transform.position.y + 0.1f, 0);
        }

        if (Input.GetKeyDown(KeyCode.C))
        {
            //print("C");

            transform.position = new Vector3(transform.position.x + 0.1f, transform.position.y - 0.1f, 0);
        }

        if (Input.GetKeyDown(KeyCode.Z))
        {
            //print("Z");

            transform.position = new Vector3(transform.position.x - 0.1f, transform.position.y - 0.1f, 0);
        }


    }
}
