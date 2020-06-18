using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PresentWord : MonoBehaviour
{
    //textファイル
    TextAsset textasset;
    [SerializeField]
    GameObject panel;
    [SerializeField]
    Text nameT;
    [SerializeField]
    Text text;
    string sentence;
    string[] line;
    string[,] lines;
    int arrayNum=0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            NextWord();
        }
    }
    void NextWord()
    {
        arrayNum++;
        if (arrayNum < line.Length)
        {
            nameT.text = lines[arrayNum, 0];
            text.text = lines[arrayNum, 1];
        }
        else
        {
            panel.SetActive(false);
            GetComponent<PlayerControl>().controlEnable(true);
        }
    }
    void LoadChapter(int chapter)
    {
        arrayNum = 0;
        textasset = Resources.Load("filename"+chapter, typeof(TextAsset)) as TextAsset;
        sentence = textasset.text;

        line = sentence.Split('\n');
        lines = new string[line.Length, line[0].Split(',').Length];
        for (int i = 0; i < line.Length; i++)
        {
            string[] tempwords = line[i].Split(',');
            for (int n = 0; n < line[0].Split(',').Length; n++)
            {
                lines[i, n] = tempwords[n];
            }
            Debug.Log(lines[i, 1]);
        }
    }
    public void CallConversation(int chapter)
    {
        LoadChapter(chapter);
        panel.SetActive(true);
        GetComponent<PlayerControl>().controlEnable(false);
    }
}
