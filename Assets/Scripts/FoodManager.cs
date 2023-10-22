using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
public class FoodManager : MonoBehaviour
{
    public string foodName;
    public int grams;
    public int calories;
    public int protein;
    public int fat;
    public int carbs;
    public Sprite icon;
    public Sprite liquid;
    public bool vegetarian;
    public bool vegan;
    public bool kosher;
    public bool meat;
    public bool milk;
    public string source;

    public GameObject blender;
    public BlenderManager blenderScript;
    public GameObject plate;
    public PlateManager plateScript;

    

    // Start is called before the first frame update
    void Start()
    {
        gameObject.transform.GetChild(0).gameObject.GetComponent<TextMeshProUGUI>().text = foodName + " (" + grams.ToString() + "g)";
        gameObject.transform.GetChild(1).gameObject.GetComponent<Image>().sprite = icon;
        gameObject.transform.GetChild(2).gameObject.GetComponent<TextMeshProUGUI>().text = calories.ToString() + "cal";
        gameObject.transform.GetChild(3).gameObject.GetComponent<TextMeshProUGUI>().text = protein.ToString() + "g Protein";
        gameObject.transform.GetChild(4).gameObject.GetComponent<TextMeshProUGUI>().text = fat.ToString() + "g Fat";
        gameObject.transform.GetChild(5).gameObject.GetComponent<TextMeshProUGUI>().text = carbs.ToString() + "g Carbs";

        blenderScript = blender.GetComponent<BlenderManager>();
        plateScript = plate.GetComponent<PlateManager>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void addFood()
    {
        blenderScript.totalCal += calories;
        blenderScript.totalProtein += protein;
        blenderScript.totalFat += fat;
        blenderScript.totalCarb += carbs;
        blenderScript.addLayer(liquid);
    }

    public void addPlateFood()
    {
        plateScript.totalCal += calories;
        plateScript.totalProtein += protein;
        plateScript.totalFat += fat;
        plateScript.totalCarb += carbs;
        plateScript.addFood(icon);
    }
}
