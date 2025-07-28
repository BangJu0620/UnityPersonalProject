using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading;
using UnityEngine;

public enum EquipType
{
    Weapon,
    Vehicle
}

public class Equipment : MonoBehaviour
{
    public static Equipment instance;

    public EquipType equipType;

    public SpriteRenderer spriteRenderer;

    public bool isEquip = false;

    EquipNPC equipNPC;

    List<EquipData> equipList = new List<EquipData>();

    private void Awake()
    {
        if(instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
        equipNPC = GetComponent<EquipNPC>();
        AddEquipmentData();
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnClickEquipment()
    {
        //equipNPC.EquipItem();
    }

    public void AddEquipmentData()
    {
        equipList.Add(new EquipData(EquipType.Weapon, 0, "Knife"));
        equipList.Add(new EquipData(EquipType.Weapon, 0, "Bow"));
        equipList.Add(new EquipData(EquipType.Vehicle, 5, "Car"));
        equipList.Add(new EquipData(EquipType.Vehicle, 10, "Vehicle"));
    }
}

public class EquipData
{
    public EquipType EquipType { get; set; }
    public float BonusSpeed {  get; set; }
    public string Name {  get; set; }
    public bool IsEquip {  get; set; }

    public EquipData(EquipType equipType, float bonusSpeed = 0f, string name = "None", bool isEquip = false)
    {
        EquipType = equipType;
        BonusSpeed = bonusSpeed;
        Name = name;
        IsEquip = isEquip;
    }
}