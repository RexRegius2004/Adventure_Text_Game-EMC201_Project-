using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
class StoryBlock
    {
    public string story;
    public string choice1Text;
    public string choice2Text;
    public StoryBlock choice1Block, choice2Block;
    public StoryBlock(string story, string choice1Text ="", string choice2Text ="", StoryBlock choice1Block = null, StoryBlock choice2Block= null)
    {
        this.story = story;
        this.choice1Text = choice1Text;
        this.choice2Text = choice2Text;
        this.choice1Block = choice1Block;
        this.choice2Block = choice2Block;
    }
    }
public class GameManager : MonoBehaviour
{
    public TextMeshProUGUI MainTextMeshpro, StaminaTextMeshPro, Choice_1_UI, Choice_2_UI;
    public GameObject Stamina_Background, Choice_1, Choice_2, Main_Text, Main_Menu;
    public string storytext;
    public string choice1;
    public string choice2;
    public int stamina_value;

    
// Start is called before the first frame update
    void Start()
    {
        MainTextMeshpro.text = storytext;
        Stamina_Background.SetActive(false);
        Choice_1.SetActive(false);
        Choice_2.SetActive(false);
        Main_Text.SetActive(false);
        Main_Menu.SetActive(true);
        
    }

    // Update is called once per frame
    void Update()
    {
        MainTextMeshpro.text = storytext;
        Choice_1_UI.text = choice1;
        Choice_2_UI.text = choice2;
        StaminaTextMeshPro.text = stamina_value.ToString();
    }
    public void Start_Game()
    {
        Stamina_Background.SetActive(true);
        Choice_1.SetActive(true);
        Choice_2.SetActive(true);
        Main_Text.SetActive(true);
        Main_Menu.SetActive(false);
    }
    
    public void Quit_Game()
    {
        Application.Quit();
    }
}
