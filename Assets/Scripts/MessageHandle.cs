using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class MessageHandle : MonoBehaviour
{
    public string text;
    public TextMeshProUGUI textValue;
    public bool isActive = false;

    public Image imageObj;
    
    public GameObject textObj;
    // Start is called before the first frame update
    void Start()
    {
        toggleBox();
    }

    // Update is called once per frame
    void Update()
    {
        textValue.text = text;
    }

    public void toggleBox()
    {
        if(isActive)
        {
            Color temp = imageObj.color;
            temp.a = 1;
            imageObj.color = temp;
            textObj.SetActive(true);
            gameObject.SetActive(true);
        } else {
            Color temp = imageObj.color;
            temp.a = 0;
            imageObj.color = temp;
            textObj.SetActive(false);
            gameObject.SetActive(false);
        }
    }

}
