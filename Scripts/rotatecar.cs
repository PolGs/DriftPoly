using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotatecar : MonoBehaviour
{
    public Transform carTransform;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        carTransform.localEulerAngles = new Vector3(carTransform.localEulerAngles.x, carTransform.localEulerAngles.y + 1, carTransform.localEulerAngles.z);
    }
}
