using UnityEngine;

public abstract class Unit : MonoBehaviour {
	public UnitColors unitColors;
    public UnitData unitData;

	public abstract void Select();
	public abstract void DeSelect();
}

[System.Serializable]
public class UnitColors {
	public Color selectedColor;
	public Color unselectedColor;
}

public class UnitData {
    public string name;
    public BaseStat offense;
    public BaseStat defense;
    public BaseStat range;
    public BaseStat reloadSpeed;
    public BaseStat speed;
}

public class BaseStat {
    public int value;
}

public class DynamicStat {
    public int maxValue;
    public int currentValue;
}