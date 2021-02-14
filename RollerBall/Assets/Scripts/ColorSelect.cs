using UnityEngine;
using UnityEngine.UI;

public class ColorSelect : MonoBehaviour
{
    public Dropdown cDropdown;
    Renderer rend;
    Renderer rend2;

    Color Red = new Color(1, 0, 0);
    Color Green = new Color(1, 1, 0);
    Color Blue = new Color(0, 0, 1);

    public static Color Ballc;

    public void colorSwitch()
    {
        switch(cDropdown.value)
        {
            default:
                Ballc = Blue;
                break;

            case 1:
                Ballc = Red;
                break;
            
            case 2:
                Debug.Log("This is Blue");
                Ballc = Blue;
                break;

            case 3:
                Ballc = Green;
                break;

        }
    }
}
