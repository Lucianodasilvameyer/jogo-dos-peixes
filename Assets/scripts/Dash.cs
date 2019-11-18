using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dash : MonoBehaviour
{
    Rigidbody2D righ;

    
    
    public float dashSpeed;

   


    // Start is called before the first frame update
    private void Awake()
    {
        righ = GetComponent<Rigidbody2D>();

    }
    
    

    
    private void FixedUpdate()
    {
        float x = Input.GetAxis("Horizontal");
        float y = Input.GetAxisRaw("Vertical");

        if (Input.GetKeyDown(KeyCode.Space))
        {
            

            Dashing(x, y);
        }
    }
    public void Dashing(float x, float y)
    {
        Debug.Log("corrida");

        Vector2 direction = new Vector2(x, y);

        righ.AddForce(direction * dashSpeed, ForceMode2D.Impulse);


    }

  
}
