using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarSpawn : MonoBehaviour
{
    public int ncars = 2;
    public GameObject[] carArray = new GameObject[2];
    public Points AngleScript;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        for (int i = 0; i < ncars; ++i)
        {
            if (i == datapass.index)
            {
                carArray[i].SetActive(true);
                AngleScript.car = carArray[i].GetComponent<Rigidbody>() ;
                AngleScript.cart = carArray[i].GetComponent<Transform>();

            }
            else carArray[i].SetActive(false);
        }

    }
}
