using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Generation : MonoBehaviour
{

    public GameObject Prefab;
    public GameObject spawnPoint;


    private void OnTriggerEnter(Collider Platform)
    {
        Instantiate(Prefab, spawnPoint.transform.position, spawnPoint.transform.rotation);
    }
}
