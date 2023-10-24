using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class prop_management : MonoBehaviour
{

    public List<GameObject> propSpawnPoints;
    public List<GameObject> propPreFabs;
     // Start is called before the first frame update
    void Start()
    {
        SpawnProps();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SpawnProps()
    {
        foreach (GameObject sp in propSpawnPoints)
        {
            int rand = Random.Range(0, propPreFabs.Count);
            GameObject prop = Instantiate(propPreFabs[rand], sp.transform.position, Quaternion.identity);
            prop.transform.parent = sp.transform;
        }
    }
}
