using UnityEngine;
using UnityEngine.UI;

public class DisplayInput : MonoBehaviour
{
    public Text text;

    void Start()
    {
        string inputValue = PlayerPrefs.GetString("userInput", "");
        text.text = inputValue;
    }
}
