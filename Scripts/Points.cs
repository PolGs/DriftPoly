using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Points : MonoBehaviour
{
    public Rigidbody car;
    public Transform cart;
    public Text angle;
    public Text points;
    private int score;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        

        Vector2 fixedVelocity = new Vector2(car.velocity.x, car.velocity.z);
        Vector2 fixedForward = new Vector2(cart.forward.x, cart.forward.z);
        int anglestring = (int) Vector2.Angle(fixedVelocity, fixedForward);
        
        

        if (anglestring > 9 && anglestring < 121 && car.velocity.magnitude > 1)
        {
            angle.text = anglestring.ToString() + "º";

            score = score + (int)(anglestring * 0.05);
            datapass.score = score;
            datapass.money = datapass.money + (int)(anglestring * 0.05);
            points.text = score.ToString();
        }




        else
        {
            angle.text = "";
        }
    }
}
