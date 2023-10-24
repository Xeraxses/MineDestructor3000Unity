using System.Collections;
using System.Collections.Generic;
using Unity.Netcode;
using UnityEngine;

public class joueur_mouvement : NetworkBehaviour
{

    //Mouvement
    public float vitesse_mouv;
    Rigidbody2D rb;
    public Vector2 direction_mouv;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();


    }

    // Update is called once per frame
    void Update()
    {
        if (!IsOwner)
        {
            return;
        }
        management_imputs();

    }

    void FixedUpdate()
    {
        if (!IsOwner)
        {
            return;
        }
        Mouvement();
    }

    void management_imputs()
    {
        float mouv_X = Input.GetAxisRaw("Horizontal");
        float mouv_Y = Input.GetAxisRaw("Vertical");

        direction_mouv = new Vector2(mouv_X, mouv_Y).normalized;

        
    }

    private void Mouvement()
    {
        rb.velocity = new Vector2 (direction_mouv.x * vitesse_mouv, direction_mouv.y * vitesse_mouv);
    }
}
