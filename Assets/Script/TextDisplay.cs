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
    public GameObject Kasumi = null;
    public GameObject Shin = null;
    public GameObject Kuda = null;
    public int TextCount = 0;
    private SearchField search;

    void Start()
    {
        search=gameObject.AddComponent<SearchField>();
        Kasumi.SetActive(false);
        Shin.SetActive(false);
        Kuda.SetActive(false);
    }

    void Update()
    {
        displayTextSpeed++;
        if (displayTextSpeed % 1 == 0)
        {
            if (textCharNumber != texts[textNumber].Length)
            {
                displayText += texts[textNumber][textCharNumber];
                textCharNumber += 1;
            }
            else
            {
                if (textNumber != texts.Length - 1)//最後のテキストか?
                {
                    if (click)
                    {
                        displayText = "";
                        textCharNumber = 0;
                        textNumber++;//テキストを一つ進める
                        if (textNumber == 5)
                        {
                            Kasumi.SetActive(true);
                            Shin.SetActive(true);
                        }
                        if (textNumber == 6)
                        {
                            Kasumi.SetActive(false);
                        }
                        if (textNumber == 7)
                        {
                            Kasumi.SetActive(true);
                        }
                        if (textNumber == 8)
                        {
                            Shin.SetActive(false);
                        }
                        if (textNumber == 9)
                        {
                            Shin.SetActive(true);
                        }
                        if (textNumber == 10)
                        {
                            Shin.SetActive(false);
                        }
                        if (textNumber == 14)
                        {
                            Kasumi.SetActive(false);
                            Shin.SetActive(true);
                        }
                        if (textNumber == 15)
                        {
                            Shin.SetActive(false);
                        }
                        if (textNumber == 16)
                        {
                            Kuda.SetActive(true);
                        }
                        if (textNumber == 18)
                        {
                            Shin.SetActive(true);
                            Kuda.SetActive(false);
                        }
                        if (textNumber == 19)
                        {
                            Shin.SetActive(false);
                            Kuda.SetActive(true);
                        }
                    }
                }
            
            }

            //最後のテキスト
            if (textNumber == texts.Length-1)
            {
                search.GetSetStoryEnd = true;
            }

            this.GetComponent<Text>().text = displayText;//displayTextをテキストを表示
            click = false;
        }
   

        if (Input.GetMouseButtonDown(0))//マウスが押されたか?
        {
            click = true;
        }
    }
}
