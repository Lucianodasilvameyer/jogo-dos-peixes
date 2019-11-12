using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraMove : MonoBehaviour
{
    public float speed;

    [SerializeField]
    Rigidbody2D body;

    // Start is called before the first frame update
    void Start()
    {
        if (!body || body == null)            
            body = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        Movimento();
    }
    public void Movimento()
    {
        Vector2 Input = new Vector2(1, 0);
        Vector2 Direction = Input.normalized;
        Vector2 Velocity = speed * Direction;
        Velocity.y = body.velocity.y;
        body.velocity = Velocity;

    }
}
