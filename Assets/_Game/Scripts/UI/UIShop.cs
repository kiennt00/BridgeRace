using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIShop : UICanvas
{
    [SerializeField] Button btnBack;

    [SerializeField] SkinItem skinItemPrefab;
    [SerializeField] Transform skinItemParent;

    private void Awake()
    {
        btnBack.onClick.AddListener(() =>
        {
            CloseDirectly();
            UIManager.Ins.OpenUI<UIMainmenu>();
        });        
    }

    public override void Open()
    {
        base.Open();

        List<Skin> skinList = DataManager.Ins.GetSkinList();

        if (skinList.Count > 0)
        {
            for (int i = 0; i < skinList.Count; i++)
            {
                SkinItem skinItem = Instantiate(skinItemPrefab, skinItemParent);
                skinItem.InitSkinItem(skinList[i]);
            }
        }
    }
}