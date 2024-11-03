using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ShopButton : MonoBehaviour
{
    public TextMeshProUGUI priceText;
    public TextMeshProUGUI countText;

    public void UpdateText(int price, int  count)
    {
        priceText.text = price.ToString();
        countText.text = count.ToString();
    }
}
