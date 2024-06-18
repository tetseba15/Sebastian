using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BotonJugar : MonoBehaviour
{
    public string nivel;

    void Start()
    {
        
    }

    void Update()
    {
        
    }

    public void Jugar()
    {
        SceneManager.LoadScene(nivel);
    }

}
