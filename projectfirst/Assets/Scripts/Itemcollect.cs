using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Itemcollect : MonoBehaviour
{
    [SerializeField] Text a; 
    [SerializeField] AudioSource mscoin;
    int coins =0;
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("coin")){
            mscoin.Play();
            Destroy(other.gameObject);
            coins++;
            a.text ="Coins:" + coins;
        }
    }
}
