using UnityEngine;

public class SoldierUnit : Unit {

	private Renderer renderer;

	private void Start() {
		renderer = GetComponent<Renderer> ();
		SetMaterialColor ( unitColors.unselectedColor );
	}

	public override void Select() {
		SetMaterialColor ( unitColors.selectedColor );
	}

	public override void DeSelect() {
		Debug.Log ( "I am being deselected" );
		SetMaterialColor ( unitColors.unselectedColor );
	}

	private void SetMaterialColor( Color color ) {
		renderer.material.color = color;
	}
}