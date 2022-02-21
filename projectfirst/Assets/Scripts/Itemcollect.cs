using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Itemcollect : MonoBehaviour
{
    [SerializeField] Text a; 
    int coins =0;
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("coin")){
            Destroy(other.gameObject);
            coins++;
            a.text ="Coins:" + coins;
        }
    }
}
