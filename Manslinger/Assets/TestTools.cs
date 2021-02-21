using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestTools : MonoBehaviour
{
    public GameObject prefabToInstantiate;
    public Transform positionToInstantiate;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //when pressing space button
        Instantiate(prefabToInstantiate, positionToInstantiate.position, Quaternion.identity);
       
    }
}
