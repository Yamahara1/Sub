using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Scene : MonoBehaviour
{
    private int SceneFlgNum = 0;
    private bool Sceneflg = false;

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
    }

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if(Sceneflg)
        {
            // Sceneの処理
            switch (SceneFlgNum)
            {
                case 0: // タイトルシーン
                    SceneManager.LoadScene("Title"); 
                    break;
                case 1: // 探索シーン１
                    SceneManager.LoadScene("Search01");
                    break;
                case 2: // 探索シーン２
                    SceneManager.LoadScene("Search02"); 
                    break;
                case 3: // 探索シーン３
                    SceneManager.LoadScene("Search03");
                    break;
                case 4: // 探索シーン４
                    SceneManager.LoadScene("Search04");
                    break;
                case 5: // 探索シーン５
                    SceneManager.LoadScene("Search05");
                    break;
                case 6: // 探索シーン６
                    SceneManager.LoadScene("Search06");
                    break;
                case 7: // 探索シーン7
                    SceneManager.LoadScene("Search07");
                    break;
                case 8: // 探索シーン8
                    SceneManager.LoadScene("Search08");
                    break;
                case 9: // 探索シーン9
                    SceneManager.LoadScene("Search09");
                    break;
                case 10: // 戦闘シーン
                    SceneManager.LoadScene("Battle"); 
                    break;
                case 11: // ゲームクリアシーン
                    SceneManager.LoadScene("GameClear"); 
                    break;
                case 12: // ゲームオーバーシーン
                    SceneManager.LoadScene("GameOver"); 
                    break;
            }
            GetSetFlgScene = false;

            // NodeSceneの処理
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
