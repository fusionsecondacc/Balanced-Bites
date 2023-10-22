using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AreaManager : MonoBehaviour
{
    public int area;
    public GameObject bg1;
    public GameObject bg2;
    public GameObject kitchenBg;
    public GameObject smoothieBg;
    public GameObject checklist;
    public GameObject foodScroll;
    public GameObject smoothieScroll;
    public GameObject plate;
    public GameObject blender;
    public GameObject totalPlate;
    public GameObject totalBlender;
    public Button button1;
    public Button button2;
    public Button button3;
    public Button button4;
    public AnimationClip checklistMove;
    public AnimationClip checklistMoveBack;
    public AnimationClip checklistMoveIn;
    public AnimationClip checklistTextMoveBack;
    public AnimationClip checklistTextMoveIn;
    public Animation clipboardAnim;
    public Animation clipboardTextAnim;
    public GameObject customer;
    public CustomerManager customerScript;


    // Start is called before the first frame update
    void Start()
    {
        area = 1;
        customerScript = customer.GetComponent<CustomerManager>();
        clipboardAnim.clip = checklistMoveIn;
        changeArea(area);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void changeArea(int area)
    {
        switch(area)
        {
            case 1:
                if(this.area != 1){
                clipboardAnim.clip = checklistMoveBack;
                clipboardTextAnim.clip = checklistTextMoveBack;
                clipboardAnim.Play();
                clipboardTextAnim.Play();
                }
                bg1.SetActive(true);
                bg2.SetActive(true);
                plate.SetActive(false);
                blender.SetActive(false);
                kitchenBg.SetActive(false);
                customer.SetActive(true);
                checklist.SetActive(true);
                foodScroll.SetActive(false);
                smoothieScroll.SetActive(false);
                totalPlate.SetActive(false);
                totalBlender.SetActive(false);
                button1.interactable = false;
                button2.interactable = true;
                button3.interactable = true;
                button4.interactable = true;
                this.area = 1;
                break;
            case 2:
                if(this.area == 1)
                {
                    clipboardAnim.clip = checklistMove;
                    clipboardTextAnim.clip = checklistTextMoveIn;
                    clipboardAnim.Play();
                    clipboardTextAnim.Play();
                }
                bg1.SetActive(false);
                bg2.SetActive(false);
                plate.SetActive(true);
                blender.SetActive(false);
                kitchenBg.SetActive(true);
                customer.SetActive(false);
                checklist.SetActive(true);
                foodScroll.SetActive(true);
                smoothieScroll.SetActive(false);
                totalPlate.SetActive(true);
                totalBlender.SetActive(false);
                button1.interactable = true;
                button2.interactable = false;
                button3.interactable = true;
                button4.interactable = true;
                this.area = 2;
                break;
            case 3:
                if(this.area == 1)
                {
                clipboardAnim.clip = checklistMove;
                clipboardTextAnim.clip = checklistTextMoveIn;
                clipboardAnim.Play();
                clipboardTextAnim.Play();
                }
                bg1.SetActive(false);
                bg2.SetActive(false);
                plate.SetActive(false);
                blender.SetActive(true);
                kitchenBg.SetActive(true);
                customer.SetActive(false);
                checklist.SetActive(true);
                foodScroll.SetActive(false);
                smoothieScroll.SetActive(true);
                totalPlate.SetActive(false);
                totalBlender.SetActive(true);
                button1.interactable = true;
                button2.interactable = true;
                button3.interactable = false;
                button4.interactable = true;
                this.area = 3;
                break;

            case 4:
                if(this.area != 1)
                {
                clipboardAnim.clip = checklistMoveBack;
                clipboardTextAnim.clip = checklistTextMoveBack;
                clipboardAnim.Play();
                clipboardTextAnim.Play();
                }
                bg1.SetActive(true);
                bg2.SetActive(true);
                plate.SetActive(false);
                blender.SetActive(false);
                kitchenBg.SetActive(false);
                customer.SetActive(true);
                checklist.SetActive(true);
                foodScroll.SetActive(false);
                smoothieScroll.SetActive(false);
                totalPlate.SetActive(false);
                totalBlender.SetActive(false);
                button1.interactable = false;
                button2.interactable = true;
                button3.interactable = true;
                button4.interactable = true;
                customerScript.stage = 2;
                this.area = 1;
                break;
        }
    }
}
