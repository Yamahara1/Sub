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
                if (textNumber != texts.Length - 1)//�Ō�̃e�L�X�g��?
                    if (click)
                    {
                        displayText = "";
                        textCharNumber = 0;
                        textNumber++;//�e�L�X�g����i�߂�
                    }
            }
            this.GetComponent<Text>().text = displayText;//displayText���e�L�X�g��\��
            click = false;
        }

        if (Input.GetMouseButtonDown(0))//�}�E�X�������ꂽ��?
            click = true;
    }
}
