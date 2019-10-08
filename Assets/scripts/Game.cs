using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class Game : MonoBehaviour
{
    
    public static Game scriptGame;

    public AudioSource audioSource;
    public AudioClip SomDeColisao;

    public GameObject[] inimigosPrefab;
    Player player_ref;

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time >= Player.scripPlayer.TempoDashInicial + Player.scripPlayer.TempoDashMax && Player.scripPlayer.recarregar == true)
        {
            Player.scripPlayer.recarregar = false;

        }
        if (Time.time >= Cascudo.scriptCascudo.reativarArmaduraInicial + Cascudo.scriptCascudo.reativarArmaduraMax && Cascudo.scriptCascudo.armadura == false)
        {

            Cascudo.scriptCascudo.ataqueDefendido = true;
        }

    }
    public void spawnarInimigos(int quantidadeDeInimigos, float distanciaMin, float distanciaMax, float heighMax, Vector2 initialPos)
    {
        Vector2 position = player_ref.transform.position;

    }
    public void somPlay(AudioClip som)
    {
        audioSource.clip = som;
        audioSource.Play();
    }
}
