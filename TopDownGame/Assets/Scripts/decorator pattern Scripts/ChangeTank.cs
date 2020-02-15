using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ChangeTank : MonoBehaviour
{
    public GameObject tank1, tank2, tank3, tankchooserhud, playershud, playbutton;
    public GameObject mainplayer;
    public bool istank1Active, istank2Active, istank3Active;
    public GameObject playerController;
    public AudioClip changesfx, change2sfx, change3sfx;
    public void showTanktype1()
    {
        Debug.Log("Change to tank1");
        AudioManager.Instance.PlaySFX(changesfx, 3.0f);
        tank1.SetActive(true);
        istank1Active = true;

    }
    public void showTanktype2()
    {
        Debug.Log("Change to tank2");
        AudioManager.Instance.PlaySFX(change2sfx, 3.0f);
        tank2.SetActive(true);
        istank2Active = true;

    }
    public void showTanktype3()
    {
        Debug.Log("Change to tank3");
        AudioManager.Instance.PlaySFX(change3sfx, 3.0f);
        tank3.SetActive(true);
        istank3Active = true;

    }

    public void DontshowTanktype1()
    {

        tank1.SetActive(false);
        istank1Active = false;

    }
    public void DontshowTanktype2()
    {

        tank2.SetActive(false);
        istank2Active = false;

    }
    public void DontshowTanktype3()
    {

        tank3.SetActive(false);
        istank3Active = false;

    }
    public void DontshowTankChooserHUD()
    {
        tankchooserhud.SetActive(false);
        playerController.SetActive(true);
    }
    public void showTankChooserHUD()
    {
        tankchooserhud.SetActive(true);
        playerController.SetActive(true);
    }

    public void showPlayerHUD()
    {
        playershud.SetActive(true);
    }
    public void DontshowPlayerHUD()
    {
        playershud.SetActive(false);
    }
    public void showPlaybutton()
    {
        playbutton.SetActive(true);
    }
    public void Restart()
    {
        Destroy(mainplayer);
    }
}
