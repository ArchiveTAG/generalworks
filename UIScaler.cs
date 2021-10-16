using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIScaler : MonoBehaviour
{
    public float resoX, resoY;
    public GameObject[] panels;
    private CanvasScaler can;
    // Start is called before the first frame update
    void Start()
    {
        can = GetComponent<CanvasScaler>();
        SetScale();
    }

    void SetScale()
    {
        resoX = (float)Screen.currentResolution.width;
        resoY = (float)Screen.currentResolution.height;
    
        for (int i = 0; i < panels.Length; i++)
        {
            panels[i].GetComponent<RectTransform>().sizeDelta = new Vector2(resoX,resoY);
        }
        
    }
}
