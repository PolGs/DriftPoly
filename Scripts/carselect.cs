using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class carselect : MonoBehaviour
{

    public int ncars = 2;
    
    public GameObject[] carArray = new GameObject[2];


    public GameObject light;
    public GameObject driftButton;
    public GameObject buyButton;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(WaitCoroutine());
        carArray[datapass.index].SetActive(true);
        //light loginc
        if (datapass.owned[datapass.index] == 0) light.SetActive(false);
        else light.SetActive(true);

        //driftbutton logic
        if (datapass.owned[datapass.index] == 0) driftButton.SetActive(false);
        else driftButton.SetActive(true);
        //buybutton logic
        if (datapass.owned[datapass.index] == 1) buyButton.SetActive(false);
        else buyButton.SetActive(true);

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void nextCar()
    {
        
        if (datapass.index == ncars - 1)
        {
            carArray[datapass.index].SetActive(false);
            datapass.index = 0;
            
            carArray[datapass.index].SetActive(true);

        }
        else {
            carArray[datapass.index].SetActive(false);
            datapass.index = datapass.index + 1;
           
            carArray[datapass.index].SetActive(true);
        }
        //light loginc
        if (datapass.owned[datapass.index] == 0) light.SetActive(false);
        else light.SetActive(true);

        //driftbutton logic
        if (datapass.owned[datapass.index] == 0) driftButton.SetActive(false);
        else driftButton.SetActive(true);
        //buybutton logic
        if (datapass.owned[datapass.index] == 1) buyButton.SetActive(false);
        else buyButton.SetActive(true);

    }

    public void prevcar()
    {
        if (datapass.index == 0)
        {
            carArray[datapass.index].SetActive(false);
            
            datapass.index = ncars - 1;
            carArray[datapass.index].SetActive(true);

        }
        else
        {
            carArray[datapass.index].SetActive(false);
        
            datapass.index = datapass.index - 1;
            carArray[datapass.index].SetActive(true);
        }
        //light loginc
        if (datapass.owned[datapass.index] == 0) light.SetActive(false);
        else light.SetActive(true);

        //driftbutton logic
        if (datapass.owned[datapass.index] == 0) driftButton.SetActive(false);
        else driftButton.SetActive(true);
        //buybutton logic
        if (datapass.owned[datapass.index] == 1) buyButton.SetActive(false);
        else buyButton.SetActive(true);

    }



    IEnumerator WaitCoroutine()
    {
       

        //yield on a new YieldInstruction that waits for 5 seconds.
        yield return new WaitForSeconds(5);

       
    }
}