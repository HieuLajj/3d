using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class playerlife : MonoBehaviour
{
    bool dead = false;
    private void Update(){
        if(transform.position.y < -2f && !dead){
            Die();
        }
    }
    private void OnCollisionEnter(Collision other) {
        if(other.gameObject.CompareTag("enemynofy")){
            GetComponent<MeshRenderer>().enabled = false;
            GetComponent<Rigidbody>().isKinematic = true;
           Die();
        }
    }
    void Die(){
        
        Invoke(nameof(ReloadLevel),1.3f);
        dead = true;
       // GetComponent<Player>().enabled = false;
        
    }
    void ReloadLevel(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
