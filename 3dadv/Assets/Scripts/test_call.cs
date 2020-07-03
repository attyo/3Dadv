using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test_call : MonoBehaviour
{
    [SerializeField]

    int chapter;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        other.GetComponent<PresentWord>().CallConversation(chapter);
        Destroy(gameObject);
    }

}
