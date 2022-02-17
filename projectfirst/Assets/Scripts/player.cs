using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("toi la lai van hieu");
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown("space")){
            Debug.Log("dan an space");
           GetComponent<Rigidbody>().velocity = new Vector3(0,5,0);
        }
        if (Input.GetKey("w")){
            GetComponent<Rigidbody>().velocity = new Vector3(0,0,5);
        }
        if (Input.GetKey("d")){
            GetComponent<Rigidbody>().velocity = new Vector3(5,0,0);
        }
        
    }
}
