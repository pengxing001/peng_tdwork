using UnityEngine;
using UnityEngine.UI;

public class RandomColor : MonoBehaviour
{
    // 颜色库
    private Color[] colors = {
        Color.red,    // 红色
        Color.black,  // 黑色
        Color.yellow, // 黄色
        Color.magenta,// 紫色
        Color.blue,   // 蓝色
        Color.green   // 绿色
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
