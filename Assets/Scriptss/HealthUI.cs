using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class HealthUI : MonoBehaviour
{

    TextMeshProUGUI hpText;

    void Awake()
    {
        hpText = GetComponent<TextMeshProUGUI>();
        PlayerHealth.healthChanged.AddListener(HealthChanged);
    }

    private void HealthChanged()
    {
        hpText.text = "HP: " + PlayerHealth.instance.currentHp.ToString();
    }

}
