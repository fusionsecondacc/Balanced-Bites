using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class PlateManager : MonoBehaviour
{
    public Image food1;
    public Image food2;
    public Image food3;
    public Image food4;
    public Image food5;
    public int highestFood = 0;
    public int totalCal;
    public int totalProtein;
    public int totalFat;
    public int totalCarb;
    public Sprite transparentSprite;
    public TextMeshProUGUI calText;
    public TextMeshProUGUI proText;
    public TextMeshProUGUI fatText;
    public TextMeshProUGUI carbcalText;
    void Start()
    {
        totalCal = 0;
        totalProtein = 0;
        totalFat = 0;
        totalCarb = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void addFood(Sprite layer)
    {
        switch(highestFood)
        {
            case 1:
                food1.sprite = layer;
                break;
            case 2:
                food2.sprite = layer;
                break;
            case 3:
                food3.sprite = layer;
                break;
            case 4:
                food4.sprite = layer;
                break;
            case 5:
                food5.sprite = layer;
                break;
        }
        highestFood += 1;
        calText.text = totalCal.ToString() + "cal";
        proText.text = totalProtein.ToString() + "g Protein";
        fatText.text = totalFat.ToString() + "g Fat";
        carbcalText.text = totalCarb.ToString() + "g Carbs";

    }

    public void resetFood()
    {
        food1.sprite = transparentSprite;
        food2.sprite = transparentSprite;
        food3.sprite = transparentSprite;
        food4.sprite = transparentSprite;
        food5.sprite = transparentSprite;
        totalCal = 0;
        totalProtein = 0;
        totalFat = 0;
        totalCarb = 0;
        highestFood = 1;
        calText.text = totalCal.ToString() + "cal";
        proText.text = totalProtein.ToString() + "g Protein";
        fatText.text = totalFat.ToString() + "g Fat";
        carbcalText.text = totalCarb.ToString() + "g Carbs";
    }
}
