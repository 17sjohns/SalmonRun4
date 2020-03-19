using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SealionSpawner : MonoBehaviour
{
    public Transform[] spawnLocations;
    public GameObject sealionPrefab;
    public GameObject sealionClone;

    public bool locationInUse = false;
   
    private void Update()
    {
        if (GetComponent<DamPlacementLocation>().inUse)
        {
            if (locationInUse == false)
            {
                Invoke("SpawnSealion", 5f);
            }
        }
        //myObject.GetComponent<SealionSpawner>().SpawnSealion();
        //just here to save the code

    }

    public void SpawnSealion()
    {
        if (GetComponent<DamPlacementLocation>().inUse)
        {
            if (locationInUse == false)
            {
                sealionClone = Instantiate(sealionPrefab, spawnLocations[0].transform.position, Quaternion.Euler(240, 0, 0)) as GameObject;

                locationInUse = true;
            }
        }
    }


}
