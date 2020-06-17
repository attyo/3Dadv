using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PresentWord : MonoBehaviour
{
    //textファイル
    TextAsset textasset;
    [SerializeField]
    Text nameT;
    Text text;
    string sentence;
    string[] line;
    string[,] lines;
    int arrayNum=0;

    // Start is called before the first frame update
    void Start()
    {
        textasset = Resources.Load("filename", typeof(TextAsset)) as TextAsset;
        sentence = textasset.text;

        line = sentence.Split('\n');
        lines = new string[line.Length,line[0].Split(',').Length];
        for (int i = 0; i < line.Length; i++)
        {
            string[] tempwords = line[i].Split(',');
            for (int n = 0; n < line[0].Split(',').Length; n++)
            {
                lines[i, n] = tempwords[n];
            }
        }
        text = GetComponent<Text>();
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
        nameT.text = lines[arrayNum, 0];
        text.text= lines[arrayNum,1];
    }
}
