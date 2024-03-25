using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class StartMenu : MenuPanel
{
    public new class UxmlFactory : UxmlFactory<StartMenu, UxmlTraits> { }

    public StartMenu() : base()
    {
        this.AddToClassList("menu-panel-full");
        new Label() { text = "Game Name" }.Parent(this).AddToClassList<Label>("menu-panel-title");
        new Button() { text = "Start" }.Parent(this).AddToClassList<Button>("menu-panel-button");
        new Button() { text = "Continue" }.Parent(this).AddToClassList<Button>("menu-panel-button");
        new Button() { text = "Options" }.Parent(this).AddToClassList<Button>("menu-panel-button");
        new Button() { text = "Credits" }.Parent(this).AddToClassList<Button>("menu-panel-button");
        new Button() { text = "Quit" }.Parent (this).AddToClassList<Button>("menu-panel-button");
    }
}

public class OptionsMenu : MenuPanel { }

public class LevelMenu : MenuPanel { }

public class CreditsMenu : MenuPanel { }