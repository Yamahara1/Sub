using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Scene : MonoBehaviour
{
    private int SceneFlgNum = 0;
    private bool Sceneflg = false;
   private SearchField search;

    public int GetSetSceneFlg
    {
        get { return SceneFlgNum; }
        set { SceneFlgNum = value; }
    }

    public bool GetSetFlgScene
    {
        get { return Sceneflg; }
        set { Sceneflg = value; }
    }

    public enum SceneName
    {
        Title,
        Search01,
        Search02,
        Search03,
        Search04,
        Search05,
        Search06,
        Search07,
        Search08,
        Search09,
        Battle,
        GameClear,
        GameOver,
        tutorial1,
        tutorial2,
        Story01,
        Story02,
        Story03,
        Story04,
        Story05,
        Story07,
        Story08,
    }

    // Start is called before the first frame update
    void Start()
    {
        search.gameObject.AddComponent<SearchField>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Sceneflg)
        {
            // Scene�̏���
            switch (SceneFlgNum)
            {
                case 0: // �^�C�g���V�[��
                    SceneManager.LoadScene("Title"); 
                    break;
                case 1: // �T���V�[���P
                    SceneManager.LoadScene("Search01");
                    break;
                case 2: // �T���V�[���Q
                    SceneManager.LoadScene("Search02"); 
                    break;
                case 3: // �T���V�[���R
                    SceneManager.LoadScene("Search03");
                    break;
                case 4: // �T���V�[���S
                    SceneManager.LoadScene("Search04");
                    break;
                case 5: // �T���V�[���T
                    SceneManager.LoadScene("Search05");
                    break;
                case 6: // �T���V�[���U
                    SceneManager.LoadScene("Search06");
                    break;
                case 7: // �T���V�[��7
                    SceneManager.LoadScene("Search07");
                    break;
                case 8: // �T���V�[��8
                    SceneManager.LoadScene("Search08");
                    break;
                case 9: // �T���V�[��9
                    SceneManager.LoadScene("Search09");
                    break;
                case 10: // �퓬�V�[��
                    SceneManager.LoadScene("Battle"); 
                    break;
                case 11: // �Q�[���N���A�V�[��
                    SceneManager.LoadScene("GameClear"); 
                    break;
                case 12: // �Q�[���I�[�o�[�V�[��
                    SceneManager.LoadScene("GameOver"); 
                    break;
                case 13:
                    SceneManager.LoadScene("00.tutorial_Part1");
                    break;
                case 14:
                    SceneManager.LoadScene("00.tutorial_Part2");
                    break;
                case 15:
                    SceneManager.LoadScene("01.Face-to-face_with_Kuda");
                    break;
                case 16:
                    SceneManager.LoadScene("02.kuda'spikup");
                    break;
                case 17:
                    SceneManager.LoadScene("03.treachery");
                    break;
                case 18:
                    SceneManager.LoadScene("04.arrest");
                    break;
                case 19:
                    SceneManager.LoadScene("05.late_of_rescue");
                    break;
                case 20:
                    SceneManager.LoadScene("07.final_battle");
                    break;
                case 21:
                    SceneManager.LoadScene("08.after_win");
                    break;
            }
            GetSetFlgScene = false;

            // NodeScene�̏���
            if (SceneFlgNum == 10)  
            {
                SceneManager.LoadSceneAsync("Node", LoadSceneMode.Additive);
                GetSetFlgScene = false;
            }
            else if (SceneFlgNum == 1 || SceneFlgNum == 2 || SceneFlgNum == 3 ||
                SceneFlgNum == 4 || SceneFlgNum == 5 || SceneFlgNum == 6 ||
                SceneFlgNum == 7 || SceneFlgNum == 8 || SceneFlgNum == 9 ||
                SceneFlgNum == 11 || SceneFlgNum == 12) 
            {
                SceneManager.UnloadSceneAsync("Node");
                GetSetFlgScene = true;
            }

        }
    }

    public void ChangeScene(int scenenum)
    {
        SceneFlgNum= scenenum;
        Sceneflg = true;
    }
}
