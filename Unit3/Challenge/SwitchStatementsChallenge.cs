using UnityEngine;
using System.Collections;

public class ConversationScript : MonoBehaviour 
{
    public int intelligence = 5;
    
    
    void Greet()
    {
        switch (intelligence)
        {
        case 5:
            print ("Hows it going?");
            break;
        case 4:
            print ("Hey nerd!");
            break;
        case 3:
            print ("Wassup?");
            break;
        case 2:
            print ("Blep Face :P!");
            break;
        case 1:
            print ("Gamer mode");
            break;
        default:
            print ("So many lines of code.");
            break;
        }
    }
}