using UnityEngine;
using System.Collections;

public class Startscreen : MonoBehaviour {

    public Texture startbutton;
    public string startlevel;
    void OnGUI()
    {
        Rect buttonrect = new Rect(Screen.width/2 - startbutton.width/2,Screen.height/2 - startbutton.height/2,startbutton.width, startbutton.height);
        if(GUI.Button(buttonrect,startbutton))
        {
            Application.LoadLevel(startlevel);
        }
    
    }

}
