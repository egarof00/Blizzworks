using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grounded : MonoBehaviour
{
    GameObject Player;
    // CharacterController controller;
    // Start is called before the first frame update
    void Start()
    {

        Debug.Log("start GroundCheck");
        // controller = GetComponent<CharacterController>();
        Player = gameObject.transform.parent.gameObject;

    }
}

//  // Update is called once per frame
//  void Update()
//  {
//    // Debug.Log("update");
//  }
//  private void OnCollisionEnter2D(Collision2D collision){
//    if (collision.collider.tag == "Ground"){
//      Player.GetComponent<movement>().isGrounded = true;
//    }
//  }
//  private void OnCollisionExit2D(Collision2D collision){
//    if (collision.collider.tag == "Ground"){
//      Player.GetComponent<movement>().isGrounded = false;
//    }
//  }


//}