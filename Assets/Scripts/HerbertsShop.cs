using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HerbertsShop : MonoBehaviour
{
    public GameObject textBox, yesButton, noButton;
    public Text text;
    public InputField iField;

   

    void Start()
    {
        text.text = "Welecome to my shop! [Press Enter to Countinue]";
        yesButton.SetActive(false);
        noButton.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (text.text == "Welecome to my shop! [Press Enter to Countinue]" && Input.GetKeyDown(KeyCode.Return))
        {
            text.text = "Would you like to browse my shop?";
            yesButton.SetActive(true);
            noButton.SetActive(true);
        }
    }

    public void ButtonYes()
    {
        if (text.text == "Would you like to browse my shop?")
        {
            yesButton.SetActive(false); 
            noButton.SetActive(false);
            text.text = "What would you like to buy?";
        }
    }
}
