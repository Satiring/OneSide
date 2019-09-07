public interface IInputService
{
    // GameBoy Basic Controls    
    float GetHorizontalAxisRaw();
    float GetVerticalAxisRaw();
    bool ButtonAPressed();
    bool ButtonBPressed();
    bool ButtonStartPressed();
    bool ButtonSelectPressed();


}