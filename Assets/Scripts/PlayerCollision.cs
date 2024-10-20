using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    //private void OnCollisionEnter(Collision collision)
    //{
    //    if(collision.gameObject.tag == "Collectable")
    //    {
    //        Destroy(collision.gameObject);
    //    }
    //}

    public PlayerScript playerScript;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Collectable")
        {
            Destroy(other.gameObject);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Obstacles")
        {
            playerScript.enabled = false;
        }
    }
}
