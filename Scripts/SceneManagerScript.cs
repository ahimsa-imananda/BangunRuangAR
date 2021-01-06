using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManagerScript : MonoBehaviour
{
    public void changeToMateriKubus()
    {
        SceneManager.LoadScene("MateriKubus");
    }

    public void changeToMateriBalok()
    {
        SceneManager.LoadScene("MateriBalok");
    }

    public void changeToMateriKerucut()
    {
        SceneManager.LoadScene("MateriKerucut");
    }

    public void changeToMateriTabung() {
        SceneManager.LoadScene("MateriTabung");
    }
    public void changeToMateriBola()
    {
        SceneManager.LoadScene("MateriBola");
    }

    public void changeToARKubus()
    {
        SceneManager.LoadScene("KubusAR");
    }

    public void changeToARBalok()
    {
        SceneManager.LoadScene("BalokAR");
    }

    public void changeToARKerucut()
    {
        SceneManager.LoadScene("KerucutAR");
    }

    public void changeToARTabung()
    {
        SceneManager.LoadScene("TabungAR");
    }
    public void changeToARBola()
    {
        SceneManager.LoadScene("BolaAR");
    }

    public void changeToKuisKubus()
    {
        SceneManager.LoadScene("KuisKubusScene");
    }

    public void changeToKuisBalok()
    {
        SceneManager.LoadScene("KuisBalokScene");
    }

    public void changeToKuisKerucut()
    {
        SceneManager.LoadScene("KuisKerucutScene");
    }

    public void changeToKuisTabung()
    {
        SceneManager.LoadScene("KuisTabungScene");
    }
    public void changeToKuisBola()
    {
        SceneManager.LoadScene("KuisBolaScene");
    }


    public void changeToDashboard() {
        SceneManager.LoadScene("DashboardScene");
    }

    public void changeToWelcome()
    {
        SceneManager.LoadScene("WelcomeScene");
    }
    public void changeToReferensi()
    {
        SceneManager.LoadScene("ReferensiScene");
    }
    
    public void exitGame()
    {
        Application.Quit();
    }
}
