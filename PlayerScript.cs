using System.Collections;
using System.Collections.Generic;
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
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 playerPos = transform.position;
        playerPos.x = Mathf.Clamp(playerPos.x, minX, maxX);
        transform.position = playerPos;
       
        if (Input.GetKey(KeyCode.RightArrow)|| Input.GetKey(KeyCode.D)|| Input.GetKey(KeyCode.Keypad6))
        {
            //Debug.Log("Right Arrow");
            transform.position = transform.position + new Vector3(speed*Time.deltaTime,0,0);
        }
        if (Input.GetKey(KeyCode.LeftArrow)|| Input.GetKey(KeyCode.A)|| Input.GetKey(KeyCode.Keypad4))
        {
            //Debug.Log("Left Arrow");
            transform.position = transform.position - new Vector3(speed*Time.deltaTime, 0, 0);
        }
    }
    private void FixedUpdate()
    {
      
        rigidbody.AddForce(0, 0, force * Time.deltaTime);
    }
    
}
