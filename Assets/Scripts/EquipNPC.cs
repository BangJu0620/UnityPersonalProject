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
            // NPC ��ȣ�ۿ�
            equipHandlerImage.gameObject.SetActive(true);
        }
    }

    public void EquipItem(Equipment equipment)
    {
        if (equipment.equipType == EquipType.Weapon)    // ����
        {
            if (isWeaponEquip)  // ���� �ִٸ�
            {
                // ���� ����� �׳� ���������ϱ�
                if (weaponPrefabs == equipment)
                {
                    weaponPrefabs.isEquip = false;
                    isWeaponEquip = false;
                    weaponPrefabs = null;
                }
                // ���� Ÿ�� �ٸ� ����� �ٲٱ�
                else
                {
                    weaponPrefabs = equipment;
                    weaponPrefabs.isEquip = true;
                    isWeaponEquip = true;
                }
            }
            else    // �� ���� �ִٸ� �׳� ����
            {
                weaponPrefabs = equipment;
                weaponPrefabs.isEquip = true;
                isWeaponEquip = true;
            }
        }
        else    // Ż��
        {
            if (isVehicleEquip)  // ���� �ִٸ�
            {
                // ���� ����� �׳� ���������ϱ�
                if (vehiclePrefabs == equipment)
                {
                    vehiclePrefabs.isEquip = false;
                    isVehicleEquip = false;
                    vehiclePrefabs = null;
                }
                // ���� Ÿ�� �ٸ� ����� �ٲٱ�
                else
                {
                    vehiclePrefabs = equipment;
                    vehiclePrefabs.isEquip = true;
                    isVehicleEquip = true;
                }
            }
            else    // �� ���� �ִٸ� �׳� ����
            {
                vehiclePrefabs = equipment;
                vehiclePrefabs.isEquip = true;
                isVehicleEquip = true;
            }
        }
    }
}
