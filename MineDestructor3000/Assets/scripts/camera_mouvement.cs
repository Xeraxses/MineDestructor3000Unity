using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camera_mouvement : MonoBehaviour
{

    public Transform cible;
    public Vector3 decalage;

    // Update is called once per frame
    void Update()
    {
        transform.position = cible.position + decalage;
    }
}
