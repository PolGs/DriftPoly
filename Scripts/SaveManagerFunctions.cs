using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using UnityEngine.UI;

public class SaveManagerFunctions : MonoBehaviour
{
    public Text moneyLabel;
    public GameObject light;
    public GameObject driftButton;
    public GameObject buyButton;
    public GameObject nextButton;
    public GameObject prevButton;
    public GameObject customButton;
    public GameObject customizeUI;



    void Start()
    {
//        PlayerPrefs.DeleteAll();
        //   SaveMAnager.LoadPlayer();
        PlayerData data = SaveMAnager.LoadPlayer();
        datapass.money = data.moneyPlayer;
        datapass.owned = data.owned;

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

    void Update()
    {
        updateLabel();
    }



    public void buy(int price)
    {
        if (datapass.money >= price)
        {
            datapass.money = datapass.money - price;
            moneyLabel.text = datapass.money.ToString();
            datapass.owned[datapass.index] = 1;
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

        SaveMAnager.SavePlayer();
    }

    public void customize()
    {
        driftButton.SetActive(false);
        buyButton.SetActive(false);
        nextButton.SetActive(false);
        prevButton.SetActive(false);
        customButton.SetActive(false);
        customizeUI.SetActive(true);
    }
    public void applycustom()
    {
        driftButton.SetActive(true);
        buyButton.SetActive(true);
        nextButton.SetActive(true);
        prevButton.SetActive(true);
        customButton.SetActive(true);
        customizeUI.SetActive(false);
    }

    public void updateLabel()
    {
        moneyLabel.text = datapass.money.ToString();
    }
    public void saveLevel()
    {
        SaveMAnager.SavePlayer();
    }
    public void loadLevel()
    {
        SaveMAnager.LoadPlayer();
    }
}
