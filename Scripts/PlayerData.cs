using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerData
{
    public int moneyPlayer;
    public int[] owned = new int[2] { 0, 0 };

    public PlayerData()
    {
       moneyPlayer = datapass.money;
       owned = datapass.owned;
    }

}
