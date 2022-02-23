using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Finish : MonoBehaviour
{
    // Start is called before the first frame update
  private void OnTriggerEnter(Collider other) {
      if(other.gameObject.name =="player"){
          SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex +1);
          Debug.Log("AEAWEF");
      }
  }
}
