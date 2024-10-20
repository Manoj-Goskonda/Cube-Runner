using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    public Rigidbody rigidbody;
    public float force = 1000f;
    public float speed = 10f;
    public float maxX;
    public float minX;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Hello Unity"); 
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 playerPosition = transform.position;
        playerPosition.x = Mathf.Clamp(playerPosition.x,minX,maxX);
        transform.position = playerPosition;

        if(Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.D))
        {
            //rigidbody.AddForce(1000f * Time.deltaTime,0, 0);
            transform.position = transform.position + new Vector3(speed * Time.deltaTime, 0, 0);
        }

        if (Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.A))
        {
            //rigidbody.AddForce(-1000f * Time.deltaTime,0, 0);
            transform.position = transform.position - new Vector3(speed * Time.deltaTime, 0, 0);
        }
        
    }

    private void FixedUpdate()
    {
        rigidbody.AddForce(0, 0, force * Time.deltaTime);
    }
}

