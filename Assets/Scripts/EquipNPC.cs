using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EquipNPC : InteractableObjectManager
{
    public Image equipHandlerImage;
    public Slider rSlider;
    public Slider gSlider;
    public Slider bSlider;

    public Equipment weaponPrefabs;
    public Equipment vehiclePrefabs;

    public Color weaponColor;

    

    bool isWeaponEquip = false;
    bool isVehicleEquip = false;

    private void Update()
    {
        weaponPrefabs.spriteRenderer.color = weaponColor;
    }

    protected override void OnCollisionEnter2D(Collision2D collision)
    {
        if ((levelCollisionLayer.value & (1 << collision.gameObject.layer)) != 0)
        {
            // NPC 상호작용
            equipHandlerImage.gameObject.SetActive(true);
        }
    }

    public void EquipItem(Equipment equipment)
    {
        if (equipment.equipType == EquipType.Weapon)    // 무기
        {
            if (isWeaponEquip)  // 끼고 있다면
            {
                // 같은 장비라면 그냥 장착해제하기
                if (weaponPrefabs == equipment)
                {
                    weaponPrefabs.isEquip = false;
                    isWeaponEquip = false;
                    weaponPrefabs = null;
                }
                // 같은 타입 다른 장비라면 바꾸기
                else
                {
                    weaponPrefabs = equipment;
                    weaponPrefabs.isEquip = true;
                    isWeaponEquip = true;
                }
            }
            else    // 안 끼고 있다면 그냥 장착
            {
                weaponPrefabs = equipment;
                weaponPrefabs.isEquip = true;
                isWeaponEquip = true;
            }
        }
        else    // 탈것
        {
            if (isVehicleEquip)  // 끼고 있다면
            {
                // 같은 장비라면 그냥 장착해제하기
                if (vehiclePrefabs == equipment)
                {
                    vehiclePrefabs.isEquip = false;
                    isVehicleEquip = false;
                    vehiclePrefabs = null;
                }
                // 같은 타입 다른 장비라면 바꾸기
                else
                {
                    vehiclePrefabs = equipment;
                    vehiclePrefabs.isEquip = true;
                    isVehicleEquip = true;
                }
            }
            else    // 안 끼고 있다면 그냥 장착
            {
                vehiclePrefabs = equipment;
                vehiclePrefabs.isEquip = true;
                isVehicleEquip = true;
            }
        }
    }
}
