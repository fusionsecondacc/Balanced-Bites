using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class BlenderManager : MonoBehaviour
{
    public Image layer1;
    public Image layer2;
    public Image layer3;
    public Image layer4;
    public Image layer5;
    public int highestLayer = 1;
    public int totalCal;
    public int totalProtein;
    public int totalFat;
    public int totalCarb;
    public Sprite transparentSprite;
    public TextMeshProUGUI calText;
    public TextMeshProUGUI proText;
    public TextMeshProUGUI fatText;
    public TextMeshProUGUI carblText;
    // Start is called before the first frame update
    void Start()
    {
        totalCal = 0;
        totalProtein = 0;
        totalFat = 0;
        totalCarb = 0;
        addLayer(transparentSprite);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void addLayer(Sprite layer)
    {
        switch(highestLayer)
        {
            case 1:
                layer1.sprite = layer;
                break;
            case 2:
                layer2.sprite = layer;
                break;
            case 3:
                layer3.sprite = layer;
                break;
            case 4:
                layer4.sprite = layer;
                break;
            case 5:
                layer5.sprite = layer;
                break;
        }
        highestLayer += 1;
        calText.text = totalCal.ToString() + "cal";
        proText.text = totalProtein.ToString() + "g Protein";
        fatText.text = totalFat.ToString() + "g Fat";
        carblText.text = totalCarb.ToString() + "g Carbs";
    }

    public void resetFood()
    {
        layer1.sprite = transparentSprite;
        layer2.sprite = transparentSprite;
        layer3.sprite = transparentSprite;
        layer4.sprite = transparentSprite;
        layer5.sprite = transparentSprite;
        totalCal = 0;
        totalProtein = 0;
        totalFat = 0;
        totalCarb = 0;
        highestLayer = 1;
        calText.text = totalCal.ToString() + "cal";
        proText.text = totalProtein.ToString() + "g Protein";
        fatText.text = totalFat.ToString() + "g Fat";
        carblText.text = totalCarb.ToString() + "g Carbs";
    }
}
