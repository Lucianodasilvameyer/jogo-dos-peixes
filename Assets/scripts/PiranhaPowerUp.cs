using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PiranhaPowerUp : MonoBehaviour
{

    public GameObject PowerUpPrefab;

    [SerializeField]
    Piranha piranha_ref;


    [SerializeField]
    Player player_ref;

    // Start is called before the first frame update
    void Start()
    {
        piranha_ref = gameObject.GetComponent<Piranha>();
    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            piranha_ref.Cardume();
        }
    }
    
    public void spawnarPowerUp(int distanciaInimigoPlayer)
    {
        Vector2 position = player_ref.transform.position;
        position.x += distanciaInimigoPlayer;
        position.y += distanciaInimigoPlayer;

        Instantiate(PowerUpPrefab, position, Quaternion.identity);
    }
}

