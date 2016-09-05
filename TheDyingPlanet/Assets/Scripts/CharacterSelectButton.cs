using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class CharacterSelectButton : MonoBehaviour {

    public void FlatShipSelection ()
    {
        PlayerPrefs.SetInt("CharacterChoice", 0);
        SceneManager.LoadScene("Scene1");
    }

    public void CurvedShipSelection()
    {
        PlayerPrefs.SetInt("CharacterChoice", 1);
        SceneManager.LoadScene("Scene1");
    }
}
