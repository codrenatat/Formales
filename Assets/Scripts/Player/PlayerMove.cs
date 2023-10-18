using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public float moveSpeed = 5;
    public float leftRightSpeed = 4;
    
    public bool isJumping = false;
    public bool comingDown = false;
    public GameObject playerObject;
    
    void Update(){
        
        transform.Translate(Vector3.forward * Time.deltaTime * moveSpeed, Space.World);
        
            if(Input.GetKey(KeyCode.A)){ 
                if(this.gameObject.transform.position.x > LevelBoundary.leftSide){ 
                        transform.Translate(Vector3.left * Time.deltaTime * leftRightSpeed);
                }    
            }
        
            if(Input.GetKey(KeyCode.D)){
                if(this.gameObject.transform.position.x < LevelBoundary.rightSide){ 
                    transform.Translate(Vector3.left * Time.deltaTime * leftRightSpeed * -1);
                }
            }

            if(Input.GetKey(KeyCode.W)){
                if(isJumping == false){ 
                    isJumping = true;
                    playerObject.GetComponent<Animator>().Play("Jump");
                }
            }
    }   
}
  