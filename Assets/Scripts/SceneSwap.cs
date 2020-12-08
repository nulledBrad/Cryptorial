using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSwap : MonoBehaviour
{
    // Start is called before the first frame update
   public void LoadHome() {
    
       SceneManager.LoadScene("MainScene");
   }
   public void LoadPatterns() {
       //TODO
   }
   public void LoadMarkets() {
       SceneManager.LoadScene("Markets");
   }
   
    // Update is called once per frame
    void Update()
    {
        
    }
}
