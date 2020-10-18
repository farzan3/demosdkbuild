using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class contestDialog : MonoBehaviour
{
    public GameObject panel;
    public Button okay;
    public Button cancel;
    // Start is called before the first frame update
    void Start()
    {
        
        okay.onClick.AddListener(O_K);
        cancel.onClick.AddListener(C_K);

        if (Advertisements.Instance.UserConsentWasSet())
        {
            Advertisements.Instance.Initialize();
        }
        else {
            panel.SetActive(true);
        }
    }

    private void O_K()
    {
        Advertisements.Instance.SetUserConsent(true);
        Advertisements.Instance.Initialize();
        panel.SetActive(false);
    }
    private void C_K()
    {
        Advertisements.Instance.SetUserConsent(false);
        Advertisements.Instance.Initialize();
        panel.SetActive(false);
    }
}
