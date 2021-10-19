using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; //ESTO ES IMPORTANTE!!

public class MainMenu : MonoBehaviour
{
    // Use this for initialization
    void Start ()
    {
        
    }
    
    // Update is called once per frame
    void Update ()
    {
        
    }
    
    public void CargarEscena()
    {
        SceneManager.LoadScene("Gameplay");
    }
}
