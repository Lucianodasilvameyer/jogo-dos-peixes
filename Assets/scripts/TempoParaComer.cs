using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class TempoParaComer : MonoBehaviour
{
    public int Contagem;
    Text textGameOver;
    public Text displayContagem;

    // Start is called before the first frame update
    void Start()
    {
        if (Contagem > 0)
        {
            InvokeRepeating("diminui", 1, 1);
        }
        else
        {

            textGameOver.gameObject.SetActive(true);
        }
    }

    // Update is called once per frame
   
    void diminui()
    {
        Contagem -= 1;
        displayContagem.text = Contagem.ToString();
    }
}
