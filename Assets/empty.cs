using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class empty : MonoBehaviour
{
    [SerializeField] private GameObject X;
    // Start is called before the first frame update
    void Start()
    {
        X.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
        Debug.Log(Screen.height+","+ Screen.width);
    }
}
