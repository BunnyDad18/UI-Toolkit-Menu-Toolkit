using System;
using System.Collections.Generic;

public static class MenuManager
{
    private static Dictionary<Type, MenuPanel> _panels = new Dictionary<Type, MenuPanel>();

    public static MenuPanel Open<T>(bool doNoNotify = false) where T : MenuPanel
    {
        if(_panels.ContainsKey(typeof(T))) return _panels[typeof(T)].Open(doNoNotify);
        MenuPanel newPanel = (MenuPanel)Activator.CreateInstance(typeof(T));
        _panels.Add(typeof(T), newPanel);
        return newPanel;
    }

    public static void RegisterPanel(MenuPanel panel)
    {
        if (_panels.ContainsKey(panel.GetType())) return;
        _panels.Add(panel.GetType(), panel);
    }
}
