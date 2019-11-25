using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimentacaoColisores : MonoBehaviour
{
    [SerializeField]
    CameraComLimites cameraComLimites_ref;

    
    Rigidbody2D body;

    

    // Start is called before the first frame update
    void Start() //posso usar void awake em vez do void start aqui? 
    {
        if (!body || body == null)  
            body = GetComponent<Rigidbody2D>();

    }

    // Update is called once per frame
    void Update()
    {
        movimento();
    }

    public void movimento()
    {
        Vector2 Input = new Vector2(1, 0);
        Vector2 Direction = Input.normalized;
        Vector2 Velocity = cameraComLimites_ref.speed * Direction;
        Velocity.y = body.velocity.y;
        body.velocity = Velocity;

    }


}