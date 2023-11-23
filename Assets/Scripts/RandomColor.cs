using UnityEngine;
using UnityEngine.UI;

public class RandomColor : MonoBehaviour
{
    // ��ɫ��
    private Color[] colors = {
        Color.red,    // ��ɫ
        Color.black,  // ��ɫ
        Color.yellow, // ��ɫ
        Color.magenta,// ��ɫ
        Color.blue,   // ��ɫ
        Color.green   // ��ɫ
    };

    private Image image;

    void Start()
    {
        image = GetComponent<Image>();
        ChangeColor();
    }

    void ChangeColor()
    {
        int index = Random.Range(0, colors.Length);
        image.color = colors[index];
    }
}
