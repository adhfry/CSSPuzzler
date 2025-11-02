using System.Collections;
using UnityEngine;
using TMPro;

public class TypingText : MonoBehaviour
{
    public TMP_Text uiText;

    [TextArea]
    public string[] messages = {
        "Welcome!",
        "CSS is Fun!",
        "Design with Style",
        "Beautify the Web",
        "Power of Code"
    };

    public float typingSpeed = 0.08f;
    public float holdTime = 1.2f;

    private Color32[] rainbowColors = new Color32[]
    {
        new Color32(255, 99, 71, 255),   // Tomato
        new Color32(255, 165, 0, 255),   // Orange
        new Color32(255, 255, 0, 255),   // Yellow
        new Color32(0, 255, 127, 255),   // Spring Green
        new Color32(0, 191, 255, 255),   // Deep Sky Blue
        new Color32(138, 43, 226, 255)   // Blue Violet
    };

    private void Start()
    {
        StartCoroutine(TypeMessages());
    }

    IEnumerator TypeMessages()
    {
        int index = 0;

        while (true)
        {
            string currentMessage = messages[index];

            for (int i = 0; i <= currentMessage.Length; i++)
            {
                uiText.text = GetColoredText(currentMessage.Substring(0, i));
                yield return new WaitForSeconds(typingSpeed);
            }

            yield return new WaitForSeconds(holdTime);

            for (int i = currentMessage.Length; i >= 0; i--)
            {
                uiText.text = GetColoredText(currentMessage.Substring(0, i));
                yield return new WaitForSeconds(typingSpeed / 2);
            }

            index = (index + 1) % messages.Length;
        }
    }

    string GetColoredText(string text)
    {
        string result = "";
        for (int i = 0; i < text.Length; i++)
        {
            Color32 color = rainbowColors[i % rainbowColors.Length];
            string hex = ColorUtility.ToHtmlStringRGB(color);
            result += $"<color=#{hex}>{text[i]}</color>";
        }
        return result;
    }
}