using UnityEngine;

public class UnityInputGameBoyService: Service,IInputService
{
    private ConfigContext _config;
    
    public UnityInputGameBoyService(Contexts contexts) : base(contexts)
    {
        _config = contexts.config;
    }

    public float GetHorizontalAxisRaw()
    {
        return Input.GetAxisRaw(_config.horizontalAxis.value);
    }

    public float GetVerticalAxisRaw()
    {
        return Input.GetAxisRaw(_config.verticalAxis.value);
    }

    public bool ButtonAPressed()
    {
        return Input.GetButtonDown(_config.buttonA.value);
    }

    public bool ButtonBPressed()
    {
        return Input.GetButtonDown(_config.buttonB.value);
    }

    public bool ButtonStartPressed()
    {
        return Input.GetButtonDown(_config.buttonStart.value);
    }

    public bool ButtonSelectPressed()
    {
        return Input.GetButtonDown(_config.buttonSelect.value);
    }
}