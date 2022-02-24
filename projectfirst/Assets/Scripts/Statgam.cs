using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Statgam : MonoBehaviour
{
  public void hii(){
      SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex +1);
  }
}
