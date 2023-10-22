using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class CustomerManager : MonoBehaviour
{
    bool spoken = false;
    bool spoken1 = false;
    public int level = 1;
    public int stage = 0;
    public Sprite[] spriteSheet1 = new Sprite[7];
    public Sprite[] spriteSheet2 = new Sprite[7];
    public List<int> macros = new List<int>();
    public List<string> restrictions = new List<string>();
    private Image imageComponent;
    public GameObject textBox;
    private MessageHandle messageScript;
    public GameObject checklist;
    private ChecklistManager checklistScript;
    public Animation checklistAnimation;
    public Animation plate;
    public Animation glass;


    // Start is called before the first frame update
    void Start()
    {
        messageScript = textBox.GetComponent<MessageHandle>();
        checklistScript = checklist.GetComponent<ChecklistManager>();
        imageComponent = GetComponent<Image>();
        if(level==1)
        {
            updateSprite(level-1, 6);
            //macros.Add(((((Random.Range(0,13)))*50)-300)+1000); //2000cal +- 300cal in increments of 50
            //macros.Add(((((Random.Range(0,7)))*10)-30)+50); //Protein: 50g  +- 30g in increments of 10
            //macros.Add(((((Random.Range(0,5)))*10)-20)+50); //Fat: 50g +- 20g in increments of 10
            macros.Add(600);
            macros.Add(60);
            macros.Add(30);
            Debug.Log(macros[0] + " " + macros[1] + " " + macros[2]);
        }

        
    }

    void updateSprite(int sheet, int spriteIndex)
    {
        imageComponent.sprite = spriteSheet1[spriteIndex];
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.x < 500 && stage == 0){
            Vector3 pos = transform.position;
            pos.x += 400f * Time.deltaTime;
            transform.position = pos;
        } else if (!spoken){
            stage = 1;
        }

        if(stage == 1 && !spoken)
        {
            StartCoroutine(giveOrder());
            spoken = true;
        }

        if(stage == 2 && !spoken1)
        {
            spoken1 = true;
            Debug.Log("in");
            StopAllCoroutines();
            StartCoroutine(judgeFood());
        }
    }

    IEnumerator giveOrder()
    {

        yield return new WaitForSeconds(1f);

        messageScript.isActive = true;
        messageScript.toggleBox();
        checklistScript.newText = true;
        updateSprite(level-1, 4);
        messageScript.text = "Hi!";
        yield return new WaitForSeconds(1f);
        updateSprite(level-1, 3);
        yield return new WaitForSeconds(1f);
        updateSprite(level-1, 4);
        messageScript.text = "Here are my nutrition goals:";
        checklistAnimation.Play();
        yield return new WaitForSeconds(1f);
        updateSprite(level-1, 3);
        yield return new WaitForSeconds(1f);
        checklistScript.newText = true;
        messageScript.text = "Calories: " + macros[0];     
        checklistScript.text = "Calories: " + macros[0];  
        updateSprite(level-1, 4);
        messageScript.toggleBox();
        yield return new WaitForSeconds(1f);
        updateSprite(level-1, 3);
        yield return new WaitForSeconds(1f);
        checklistScript.newText = true;
        messageScript.toggleBox();
        messageScript.text = "Protein: " + macros[1] + "g";    
        checklistScript.text = "Protein: " + macros[1] + "g";  
        updateSprite(level-1, 4);
        yield return new WaitForSeconds(1f);
        updateSprite(level-1, 3);
        yield return new WaitForSeconds(1f);
        checklistScript.newText = true;
        messageScript.toggleBox();
        messageScript.text = "Fat: " + macros[2] + "g";    
        checklistScript.text = "Fat: " + macros[2] + "g";    
        updateSprite(level-1, 4);
        yield return new WaitForSeconds(1f);
        updateSprite(level-1, 3);
        yield return new WaitForSeconds(1f);
        updateSprite(level-1, 6);
        messageScript.isActive = false;
        messageScript.toggleBox();
        yield break;

    }

    IEnumerator judgeFood()
    {
        updateSprite(level-1, 6);
        yield return new WaitForSeconds(1f);
        plate.Play();
        yield return new WaitForSeconds(2f);
        glass.Play();

        updateSprite(level-1, 3);
        yield return new WaitForSeconds(2f);
        updateSprite(level-1, 2);
        messageScript.isActive = true;
        messageScript.text = "Thanks";   
        yield return new WaitForSeconds(2f);
        
        updateSprite(level-1, 6);
        messageScript.isActive = false;
        messageScript.toggleBox();
        

    }

}
