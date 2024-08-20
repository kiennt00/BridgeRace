using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class SkinItem : MonoBehaviour
{
    [SerializeField] Skin skin;

    [SerializeField] Button btnBuy, btnEquip;
    [SerializeField] TextMeshProUGUI textBuy;
    [SerializeField] Image skinImage;
    public void InitSkinItem(Skin skin)
    {
        this.skin = skin;

        btnBuy.onClick.AddListener(() =>
        {
            
        });
        btnEquip.onClick.AddListener(() =>
        {

        });

        textBuy.text = this.skin.price.ToString();
        skinImage.sprite = this.skin.skinImageSprite;
    }
}
