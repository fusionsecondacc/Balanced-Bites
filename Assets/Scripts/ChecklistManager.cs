using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class ChecklistManager : MonoBehaviour
{
    public string text;
    public string currentText;
    public TextMeshProUGUI textValue;
    public bool newText = false;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(newText)
        {
            StartCoroutine(typeText());
        }
    }

    IEnumerator typeText()
    {
        newText = false;
        textValue.text = currentText;
        for (int i = 0; i<text.Length; i++)
        {
            textValue.text = textValue.text + text[i];
            yield return new WaitForSeconds(0.06f);
        }
        currentText = textValue.text + "\n";
    }
}
