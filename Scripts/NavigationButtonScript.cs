using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NavigationButtonScript : MonoBehaviour
{
    public GameObject extraOptionPanel;
    public GameObject berandaPanel;
    public GameObject materiPanel;
    public GameObject kuisPanel;
    // Start is called before the first frame update
    public void buttonExtraOptionClicked()
    {
        if (extraOptionPanel.gameObject.activeSelf)
        {
            extraOptionPanel.gameObject.SetActive(false);
        } else
        {
            extraOptionPanel.gameObject.SetActive(true);
        }
    }

    public void buttonBerandaClicked()
    {
        berandaPanel.gameObject.SetActive(true);
        materiPanel.gameObject.SetActive(false);
        kuisPanel.gameObject.SetActive(false);
    }

    public void buttonMateriClicked()
    {
        berandaPanel.gameObject.SetActive(false);
        materiPanel.gameObject.SetActive(true);
        kuisPanel.gameObject.SetActive(false);
    }

    public void buttonKuisClicked()
    {
        berandaPanel.gameObject.SetActive(false);
        materiPanel.gameObject.SetActive(false);
        kuisPanel.gameObject.SetActive(true);
    }
}
