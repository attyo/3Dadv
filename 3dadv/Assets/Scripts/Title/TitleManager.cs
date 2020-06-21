using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TitleManager : MonoBehaviour
{
    [SerializeField]
    private GameObject fadeUI;
    [SerializeField]
    private GameObject startUI;

    void Start()
    {
        StartCoroutine(WaitPressAnyKey());
    }

    IEnumerator WaitPressAnyKey()
    {
        yield return new WaitForSeconds(2.5f);

        startUI.SetActive(true);

        yield return new WaitUntil(() => Input.anyKeyDown);

        fadeUI.SetActive(true);
        
        // 鳴らせたら効果音鳴らす
        
        // フェードと効果音の時間だけ待つ
        yield return new WaitForSeconds(2);

        SceneManager.LoadScene("dungon");
    }
}
