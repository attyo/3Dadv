using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
using UniRx;

public class TitleCharacters : MonoBehaviour
{
    private Text text;
    private AudioSource audioSource;
    private const string title = "The Advent";

    // Start is called before the first frame update
    void Start()
    {
        text = GetComponent<Text>();
        audioSource = GetComponent<AudioSource>();

        Observable.Interval(TimeSpan.FromMilliseconds(200))
            .Take(title.Length)
            .Subscribe(count =>
            {
                audioSource.Play();
                audioSource.panStereo = UnityEngine.Random.Range(-1.0f, 1.0f);
                text.text = title.Substring(0, (int)count + 1);
            }).AddTo(this);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
