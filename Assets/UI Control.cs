using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;


public class UIControl : MonoBehaviour
{
    public void OpenWindow(GameObject panel)
    {
        panel.SetActive(true);
    }

    public void CloseWindow(GameObject panel)
    {
        panel.SetActive(false);
    }

    public void DeleteButton(GameObject panel)
    {
        Destroy(panel);
    }
}
