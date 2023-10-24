using System.Collections;
using System.Collections.Generic;
using Unity.Netcode;
using UnityEngine;

public class game_manager : NetworkBehaviour
{
    //le spawn de perso en début de scene

    public GameObject playerPrefab;

    void Start()
    {
        Instantiate(playerPrefab, new Vector3(0, 0, -1), Quaternion.identity);
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
