using System.Collections;
using System.Collections.Generic;
using Unity.Netcode;
using UnityEngine;

public class joueur : NetworkBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        transform.position = new Vector3(0, 0, -1);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
