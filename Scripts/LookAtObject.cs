using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookAtObject : MonoBehaviour
{
    public CubeNear nearHandler;
    public GameObject target;
    // Start is called before the first frame update
    void Start() {
        nearHandler.OnNearArea += LookAtTarget;
    }

    void LookAtTarget() {
        GameObject[] group2_spiders;
        group2_spiders = GameObject.FindGameObjectsWithTag("Group2Spider");
        foreach (GameObject spider in group2_spiders) {
            spider.transform.LookAt(target.transform);
        }
    }
}
