using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class submitButtonClicked : MonoBehaviour
{
    public GameObject recapPanel;
    public GameObject konfirmasiImage;


    public void showKonfirmasiImage()
    {
        konfirmasiImage.gameObject.SetActive(true);
    }
    public void hideKonfirmasiImage()
    {
        konfirmasiImage.gameObject.SetActive(false);
    }
    public void showRecapPanel() {
        recapPanel.gameObject.SetActive(true);
    }
    public void hideRecapPanel() {
        recapPanel.gameObject.SetActive(false);
    }
}
