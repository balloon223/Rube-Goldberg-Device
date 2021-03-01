using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallBehavior : MonoBehaviour
{
    Rigidbody2D myBody;
    // Start is called before the first frame update
    void Start()
    {
        myBody = gameObject.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space)){
            myBody.AddForce(new Vector3(5000, 0, 0));
        }
    }

    void OnCollisionEnter2D(Collision2D other){
        Debug.Log("Hit Something");
    }
}