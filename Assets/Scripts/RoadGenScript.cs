using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoadGenScript : MonoBehaviour
{
    public Transform startPos;
    int nextstep=0;
    public GameObject[] PrefabsRoad;//hold various types of road

    void Start()
    {
 
    }

    // Update is called once per frame
    void Update()
    {
        nextstep+=9;
        Instantiate(PrefabsRoad[Random.Range(0, PrefabsRoad.Length)], new Vector3(transform.position.x + nextstep, startPos.position.y, startPos.position.z), Quaternion.identity);
    }
}
