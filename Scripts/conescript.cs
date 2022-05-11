using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class conescript : MonoBehaviour
{

    public ParticleSystem system;
    private bool first = true;

    // Start is called before the first frame update
    void Start()
    {
        




    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (first) {
            system.Play(true);
            first = false;
        }
        
    }
}
