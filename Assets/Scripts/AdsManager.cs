using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Advertisements;

public class AdsManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Advertisement.Initialize("c9dd8b86-9647-421e-8541-9794440dfe21");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
