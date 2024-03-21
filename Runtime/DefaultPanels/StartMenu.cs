using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class StartMenu : MenuPanel
{
    public StartMenu() : base()
    {
        new Label() { text = "Game Name" }.Parent(this);
        new Button() { text = "Start" }.Parent(this);
        new Button() { text = "Continue" }.Parent(this);
        new Button() { text = "Options" }.Parent(this);
        new Button() { text = "Credits" }.Parent(this);
        new Button() { text = "Quit" }.Parent (this);
    }
}

public class OptionsMenu : MenuPanel { }

public class LevelMenu : MenuPanel { }

public class CreditsMenu : MenuPanel { }