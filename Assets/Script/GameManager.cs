using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    public TextMeshProUGUI MainTextMeshpro, StaminaTextMeshPro, EndingTextMeshPro;
    public GameObject Stamina_Background, Main_Text, Main_Menu, Blocks, Restart, Ending;
    public GameObject block2, block3, block4, block5, block6, block7, block8, block9, block10, block11, block12, block13, block14, block15;
    public string storytext;
    public string storytext2;
    public string choice1;
    public string choice2;
    public string ending;
    public int stamina_value;




    // Start is called before the first frame update
    void Start()
    {

        Stamina_Background.SetActive(false);
        Blocks.SetActive(false);
        Main_Text.SetActive(false);
        Main_Menu.SetActive(true);
        Restart.SetActive(false);

    }

    // Update is called once per frame
    private void Update()
    {
        MainTextMeshpro.text = storytext;
        StaminaTextMeshPro.text = stamina_value.ToString();
        EndingTextMeshPro.text = ending;
    }

    public void Start_Game()
    {
        Stamina_Background.SetActive(true);
        Main_Text.SetActive(true);
        Main_Menu.SetActive(false);
        Restart.SetActive(false);
        Ending.SetActive(false);
        Blocks.SetActive(true);
        block2.SetActive(true);
        block3.SetActive(true);
        block4.SetActive(false);
        block5.SetActive(false);
        block6.SetActive(false);
        block7.SetActive(false);
        block8.SetActive(false);
        block9.SetActive(false);
        block10.SetActive(false);
        block11.SetActive(false);
        block12.SetActive(false);
        block13.SetActive(false);
        block14.SetActive(false);
        block15.SetActive(false);
        storytext = "Once upon a time a young girl playing hide and seek with her friends stumbled upon a peculiar sight whale trying to hide. Inside the forest lies a towering tree hollowed inside, perfect for a hiding place. She went in with a grin on her face imagining her victory in winning hide and seek but little did she know the magic that lies on the tree. The young girl hid inside so that her friends could not find her. She can hear the seeker trying to lure the hiders out, and she giggled to herself marveling at her genius hiding spot, minutes later and she could not hear the seekers nor her friends. “Maybe everyone has been found,” she thought to herself, “perhaps I should reveal myself and declare myself the victor”. She walked out of the tree with glimmering lights shining in her eyes, as she adjust her vision she saw a forest full of sunshine and vibrance, such beauty and wonder she has never seen. A forest where mushrooms talk, rocks float, trees are moving, and animals are dancing to the music, a forest where the young girl's mind thought she was a fairy tale land. After being entranced by the forest, she wonders where she is, she looked for the path home but could only find a different path that she never ventured before. Should she go deeper into the forest or follow the path?";
        stamina_value = 5;
    }

    public void Block2()
    {
        block2.SetActive(false);
        block3.SetActive(false);
        block4.SetActive(true);
        block5.SetActive(true);
        storytext = "Deeper into the forest she goes as trees shift and move, curious about the human threading the grass as she moves towards an unknown destination. As she approaches a clearing she saw a creature that can be only described as an amalgamation of fox and bird weeping in the distance, the girl empathizes with the creature despite its unusual look. Should she follow the creature or venture forward to the forest looking for the way home?";
        stamina_value = 4;
    }
    public void Block3()
    {
        block2.SetActive(false);
        block3.SetActive(false);
        block6.SetActive(true);
        block7.SetActive(true);
        storytext = "Curiosity filled her mind as she stares at the unknown path, despite not knowing where it will lead her, she followed it and let it decide her destination. She as walks onto the path she stumbles upon a talking frog singing a merry tune “Let greed and fear inside your mind and the smile of the feywilds you will find” she continued to her path pondering about the frog’s song. After crossing the forest and a river, she found a hill tall enough to see the way of the land “I should climb the and find a way home like scouts that hunt for food” she thought to herself, and so she climb the hill and look upon the land. Climbing the hill took a lot of energy from her, she is just a child after all so she looks at the hill and found a cave, safe from her falling from the hill, or she could rest near the cliff as she finds a way out of the forest looking below.";
        stamina_value = 4;
    }
    public void Block4()
    {
        block4.SetActive(false);
        block5.SetActive(false);
        block8.SetActive(true);
        block9.SetActive(true);
        storytext = "She follows the fox-bird creature as it cries away deeper into the forest. The young girl is curious about the creature's predicament and tried to approach it calmly. The creature is wary of the human but intrigued by the girl’s calm nature but still engulfed by the sadness it's carrying. The young girl wants to make the creature happy as a creature this sad should belong in this mystical forest. Should she comfort the creature? or Cheer it up by singing a song?";
        stamina_value = 3;
    }
    public void Block5()
    {
        block4.SetActive(false);
        block5.SetActive(false);
        block10.SetActive(true);
        block11.SetActive(true);
        storytext = "She decided to go deeper into the forest exhausted from walking for two hours. She looks tired despite just walking for two hours like energy is being sapped away from her. The forest darkens as she goes further, trees shifting in the shadows, and fatigue is taking a toll on her. Should she rest and sleep or push forward to the forest?";
        stamina_value = 2;
    }
    public void Block6()
    {
        block6.SetActive(false);
        block7.SetActive(false);
        block12.SetActive(true);
        block13.SetActive(true);
        storytext = "As she goes to the cliff she saw the forest in its entirety, looking a bit further is an autumn forest and a winter forest separated by a river. She wonders at the sight of the fey wilds while a shifting noise can be heard behind her, a figure shapeless in form arrives. She turned around and see the creature change shape as it analyze her, it turns into a spider, a swarm of locusts, a fire with billowing smoke, a creature with a lot of holes, a clown, and lastly, it turned into her dead mother when she is ridden with diseases during the plague. The image of her mother inches forward to her as her eyes swollen and her skin purple and rotten, the young girl is frightened by this act. Should she try to run away or stay put?";
        stamina_value = 3;
    }
    public void Block7()
    {
        block6.SetActive(false);
        block7.SetActive(false);
        block14.SetActive(true);
        block15.SetActive(true);
        storytext = "She rests in the cave trying to catch her breath as a dragon appears to greet her. The dragon has prismatic scales and instead of usual wings that are bat-like, this dragon has wings akin to butterflies, dazzling with colors. “A human in the feywilds? Speak the purpose of your visit to my cave” It speaks with an eerie voice, “I just want to go home, I rested here to find the way” she responded almost crying, “It is rude here in the fey wilds to come unannounced into a lair of a fae creature like me but giving a gift is an act of friendship that may disregard this rule so what do you have to offer?”. The only thing that she has is a toy doll her mother sown for her before she dies but the dragon might eat her up if she doesn’t give up her doll. Should she give up her doll or refuse to give a gift and leave the cave?";
        stamina_value = 3;
    }
    public void Block8()
    {
        block8.SetActive(false);
        block9.SetActive(false);
        Restart.SetActive(true);
        storytext = "She approached the creature and gave it a warm hug just as she comforts the creature, it felt her sorrow when she lost her mother back when she was younger. The creature embraced the girl as well, sharing their sadness, and feeling each other's pain. The creature now understands the girl as she needs to go back home and so the creature unfolds its hidden wings carrying her to a familiar place, the tree where she hid from the seekers of their game. The creature gently put her to the ground and urges her to go inside the hollow part of the tree. She went in and nothing happened, she turned around and the creature is gone. She went outside the tree and was shocked to be back again in the forest she knows. A young boy then tagged her at the back suggesting that the game is still going on like no time has passed when she was in that magical forest like nothing has happened.";
        stamina_value = 5;
        ending = "-GOOD END-";
        Ending.SetActive(true);
    }
    public void Block9()
    {
        block8.SetActive(false);
        block9.SetActive(false);
        Restart.SetActive(true);
        storytext = "As she sings happy songs to the creature, it felt her happiness and was drawn to it. The creature finds it fascinating that a human can have so much happiness inside. The creature stand up while she was singing and grappled her, the young girl is scared and alarmed by this as she tries to break free from the creature’s paws then the creature opened its mouth and sapped the happiness from her. She screamed as the creature is eating away her emotions and happy memories, draining her will away until she succumbed to the sadness that she felt when her mother died the creature stopped and fly away leaving behind a girl a husk of herself laying on the ground crying to herself.";
        stamina_value = -1;
        ending = "-BAD END-";
        Ending.SetActive(true);
    }
    public void Block10()
    {
        block10.SetActive(false);
        block11.SetActive(false);
        Restart.SetActive(true);
        storytext = "She pushed forward to the forest as it darkens and turn gloomy, panting and sweating as she desperately try to find the way home. She sees visions of faces laughing in the trees wickedly as they shift and contort in the shadows, the branches looking like snakes ready to bite her, the grass oddly sharp, and eyes looking evading her sight watching her suffer. Then she reached a clearing in the forest where she sees a familiar tree, a tree where she hid from the seekers of their game. She tries to take a break inside the maddening aura of the forest and then she imagined her family and friends trying to find her in the forest but to no avail, anxiety begins to well up around and she fell unconscious inside the tree. She woke in the infirmary of her village as the nurse check on her. She said that her friends found her in the forest ground unconscious, after the nurse check her father hugged her as he worries that something has happened to her and she proceeds to hug him back as her fear and anxiety melts away from her experience in the feywilds.";
        stamina_value = 1;
        ending = "-GOOD END-";
        Ending.SetActive(true);

    }
    public void Block11()
    {
        block10.SetActive(false);
        block11.SetActive(false);
        Restart.SetActive(true);
        storytext = "She sleeps on the forest floor as the forest darkens and turns gloomy singing herself to sleep as the forest tries to scare her. She closes her eyes and she fell asleep drifting away to her slumber then she wakes up on the forest floor back in the same forest where she hid. The sky is nowhere to be seen as rain clouds fill the skies. She tries to get home to avoid the rain but the home she is to go back to is not the same as before as the house is older and dilapidated, and the farm is bigger than before. She knocked on the door seeing an old man in farmer’s clothing, old man is petrified at the sight of her sister “Sister?” he said in a sad tone “but you were missing for decades, what happened to you?”, but before she can speak she aged immediately as time catches on to her, she embraced her brother one last time as she turns into ashes. The old man cried to himself trying to hold the ashes of his sister.";
        stamina_value = -99;
        ending = "-BAD END-";
        Ending.SetActive(true);
    }
    public void Block12()
    {
        block12.SetActive(false);
        block13.SetActive(false);
        Restart.SetActive(true);
        storytext = "Despite her fears she tried to run away from the undead visage of her mother. She ran as fast as she could but she, unfortunately, tripped into a stone she fell on the cliff blinded by fear. She plummeted to the ground head bleeding and her body broken, she looks up as she sees her dead mother waving at her at the top of the cliff watching her pass away.";
        stamina_value = 0;
        ending = "-BAD END-";
        Ending.SetActive(true);

    }
    public void Block13()
    {
        block12.SetActive(false);
        block13.SetActive(false);
        Restart.SetActive(true);
        storytext = "She froze from the fear of her dead mother unable to move as fear consumes her being. She watches as the visage of her dead mother opened its mouth to feed on the fear she is exuding. The creature returned to its amorphous form as it saps the fear away from her. After the creature consumed her fear it spoke in an unnatural tone “ Thank you for feeding me, let me give you a gift in return” the creature gave a map to her pointing to a familiar tree she has hid before. She sets up her journey to the tree and went inside, nothing happened until she turned around. She went outside the tree and was shocked to be back again in the forest she knows. A young boy then tagged her at the back suggesting that the game is still going on like no time has passed when she was in that magical forest like nothing has happened.";
        stamina_value = 1;
        ending = "-GOOD END-";
        Ending.SetActive(true);
    }
    public void Block14()
    {
        block14.SetActive(false);
        block15.SetActive(false);
        Restart.SetActive(true);
        storytext = "She gave the doll to the dragon as it absorb the emotions put in the doll, the love her mother gave to it as well as the sentiment the young girl sapped into the maw of the dragon. The dragon is pleased with the gift and so it gave her shoes enchanted with wishing magic. She donned the shoes and closed her eyes wishing to go back home to where her father and her friends are. She opened her eyes and was shocked to be back again in the forest she knows. A young boy then tagged her at the back suggesting that the game is still going on like no time has passed when she was in that magical forest like nothing has happened.";
        stamina_value = 5;
        ending = "-GOOD END-";
        Ending.SetActive(true);

    }
    public void Block15()
    {
        block14.SetActive(false);
        block15.SetActive(false);
        Restart.SetActive(true);
        storytext = "Refusing to give her doll she walked away from the dragon breaking a fae custom that all fae creatures obey. The dragon is furious about the rudeness the girl presented so it conjured up its magic to put a curse on the young girl. The girl watched as her body turns to wood, her legs turned into roots, her arms turned into branches, and her mind crazed with wickedness. Her form changed into a tree as she shambles into the forest locking her place as her roots cling to the ground permanently turning her into a part of the forest.";
        stamina_value = 0;
        ending = "-BAD END-";
        Ending.SetActive(true);
    }
    public void Quit_Game()
    {
        Application.Quit();
    }
}
