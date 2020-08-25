using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class quickSelect : MonoBehaviour
{
    [Header("Colors")]
    public Color selected;
    public Color unselected;
    float scrollWheel;
    [Header("Fast select items")]
    public GameObject[] items;
    int selectedObjectIndex;
    // Start is called before the first frame update
    void Start()
    {
        selectedObjectIndex = 2;
    }

    // Update is called once per frame
    void Update()
    {
        scrollWheel = Input.GetAxis("Mouse ScrollWheel");
        if(scrollWheel !=0)
        {
            if(scrollWheel > 0)
            {
                selectedObjectIndex++;
                if(selectedObjectIndex >= items.Length-1)
                {
                    selectedObjectIndex = items.Length-1;
                }
            }else if(scrollWheel < 0)
            {
                selectedObjectIndex--;
                if(selectedObjectIndex <= 0)
                {
                    selectedObjectIndex = 0;
                }
            }
            //Debug.Log(selectedObjectIndex.ToString());
        }

        for(int i = 0; i<items.Length;i++)
        {
            if(i==selectedObjectIndex)
            {
                items[i].GetComponent<Image>().color = selected;                
            }else
            {
                items[i].GetComponent<Image>().color = unselected;                
            }
        }
        //Debug.Log(scrollWheel.ToString());
    }
}
