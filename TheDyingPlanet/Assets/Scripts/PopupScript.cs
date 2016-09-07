using UnityEngine;
using System.Collections;

public class PopupScript : MonoBehaviour
{
    // panel that you want to open or close
    public GameObject panel;

    // by default the panel will not be active
    void Start()
    {
        panel.SetActive(false);
    }

    // open the panel by setting it active
    public void Open()
    {
        panel.SetActive(true);
    }

    // close the panel by setting active to false
    public void Close()
    {
        panel.SetActive(false);
    }
}
