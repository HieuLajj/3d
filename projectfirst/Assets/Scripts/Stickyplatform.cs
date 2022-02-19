using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stickyplatform : MonoBehaviour
{
    private void OnCollisionEnter(Collision other) {
        if(other.gameObject.name == "player"){
            other.gameObject.transform.SetParent(transform);
        }
    }
    private void OnCollisionExit(Collision other) {
         if(other.gameObject.name == "player"){
            other.gameObject.transform.SetParent(null);
        }
    }
}
