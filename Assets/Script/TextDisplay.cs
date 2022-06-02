using UnityEngine;
using UnityEngine.UI;

public class TextDisplay : MonoBehaviour
{
    public string[] texts;
    int textNumber;
    string displayText;
    int textCharNumber;
    int displayTextSpeed;
    bool click;

    void Update()
    {
        displayTextSpeed++;
        if (displayTextSpeed % 10 == 0)
        {
            if (textCharNumber != texts[textNumber].Length)
            {
                displayText += texts[textNumber][textCharNumber];
                textCharNumber += 1;
            }
            else
            {
                if (textNumber != texts.Length - 1)//最後のテキストか?
                    if (click)
                    {
                        displayText = "";
                        textCharNumber = 0;
                        textNumber++;//テキストを一つ進める
                    }
            }
            this.GetComponent<Text>().text = displayText;//displayTextをテキストを表示
            click = false;
        }

        if (Input.GetMouseButtonDown(0))//マウスが押されたか?
            click = true;
    }
}
