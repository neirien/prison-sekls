using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Generation : MonoBehaviour
{
    List<GameObject> prefabList = new List<GameObject>();
    public GameObject Prefab1;
    public GameObject Prefab2;
    public GameObject Prefab3;
    public GameObject spawnPoint;
    Collider platformColl;
    

    void Start()
    {
        prefabList.Add(Prefab1);
        prefabList.Add(Prefab2);
        prefabList.Add(Prefab3);
        platformColl = GetComponent<Collider>();
        

    }

    private void OnTriggerEnter(Collider platformColl)
    {
        if (platformColl.gameObject.tag == "Platform")
        {
            int prefabIndex = UnityEngine.Random.Range(0, 3);
            Instantiate(prefabList[prefabIndex], spawnPoint.transform.position, spawnPoint.transform.rotation);
        }
                
    }

    //private void OnTriggerExit(Collider collider)
    //{
        //Destroy(this.gameObject);            
    //}

    void OnBecameInvisible()
    {
        Destroy(this.gameObject);
        
    }
}
