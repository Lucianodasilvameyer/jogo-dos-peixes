using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDash : MonoBehaviour
{
    Rigidbody2D righ;
    public int dashSpeed;

    [SerializeField]
    CoolDownDoubleDash coolDownDoubleDash;

    // Start is called before the first frame update

    private void Awake()
    {
        righ = gameObject.GetComponent<Rigidbody2D>();
    }
    

    // Update is called once per frame
    private void FixedUpdate()
    {
        float x = Input.GetAxis("Horizontal");
        float y = Input.GetAxisRaw("Vertical");
        if (Input.GetKeyDown(KeyCode.Space) && coolDownDoubleDash.recarregar == false)
        {
            Dash(x, y);
            //game.TempoDashInicial = Time.time;
            //game.recarregar = true;
        }
    }



    public void Dash(float x, float y)
    {
        Vector2 direction = new Vector2(x, y);
        righ.AddForce(direction * dashSpeed, ForceMode2D.Impulse);//força e modo respectivamente? no caso o direction vira um vetor ao ser adicionado força a ele 
    }
}
