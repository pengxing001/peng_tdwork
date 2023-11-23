using UnityEngine;
using UnityEngine.UI;

public class StoreInput : MonoBehaviour
{
    public InputField inputField;
    public Button submitButton;

    void Start()
    {
        // 在用户点击按钮后调用StoreValue方法
        submitButton.onClick.AddListener(StoreValue);
    }

    void StoreValue()
    {
        string inputValue = inputField.text;
        PlayerPrefs.SetString("userInput", inputValue);
    }

    private void OnApplicationQuit()
    {
        PlayerPrefs.DeleteKey("userInput");
    }
}
