using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    public float horizontalInput;
    public float speed = 10.0f;
    public float xRange = 10.0f;
    public GameObject projecteilPrefab; 
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * horizontalInput * Time.deltaTime * speed);

         //set the boundaries player's zone
        if (transform.position.x < -xRange)
           transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);
        else if (transform.position.x > xRange)
           transform.position = new Vector3(xRange, transform.position.y, transform.position.z);

        //launch projecteil from the player's input and position
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(projecteilPrefab, transform.position, projecteilPrefab.transform.rotation);
        }
    }
}
