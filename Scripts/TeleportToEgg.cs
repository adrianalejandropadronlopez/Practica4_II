using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeleportToEgg : MonoBehaviour
{
    public CubeNear nearHandler;
    public GameObject egg;
    // Start is called before the first frame update
    void Start()
    {
        nearHandler.OnNearArea += TeleportSpiderToEgg;
    }

    void TeleportSpiderToEgg() {
        GameObject[] group1_spiders;
        group1_spiders = GameObject.FindGameObjectsWithTag("Group1Spider");
        foreach (GameObject spider in group1_spiders) {
            spider.transform.position = egg.transform.position;
        }
    }
}
