using System;
using UnityEngine.UIElements;

public class MenuPanel : VisualElement
{
    public static Action OnOpen { get; set; }
    public static Action OnClose { get; set; }

    public static MenuPanel CurrentPanel => _currentPanel;

    private static MenuPanel _currentPanel;
    private MenuPanel _lastPanel;

    public MenuPanel()
    {
        MenuManager.RegisterPanel(this);
    }

    public virtual MenuPanel Open(bool doNoNotify = false)
    {
        if(_lastPanel == null && !doNoNotify) OnOpen?.Invoke();
        _lastPanel = _currentPanel;
        _currentPanel = this;
        _lastPanel?.Display(false);
        this.Display(true);
        return this;
    }

    public virtual void Close(bool doNoNotify = false)
    {
        _lastPanel?.Display(true);
        _currentPanel = _lastPanel;
        this.Display(false);
        if(_lastPanel == null && !doNoNotify) OnClose?.Invoke();
    }

    public virtual void Accept() { }
    public virtual void Cancel() { }
    public virtual void Left() { }
    public virtual void Right() { }
}
