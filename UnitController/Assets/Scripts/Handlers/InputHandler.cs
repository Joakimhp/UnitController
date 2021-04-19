using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputHandler : Handler {
	private Camera camera;

	private List<Unit> selectedFriendlyUnits;
	private bool selectingFriendlyUnits = false;

	public override void Initialize() {
		camera = Camera.main;
		selectedFriendlyUnits = new List<Unit> ();
	}

	private void Update() {
		if ( Input.GetMouseButtonDown ( 0 ) ) {
			RaycastHit hit;
			Ray ray = camera.ScreenPointToRay ( Input.mousePosition );

			if ( Physics.Raycast ( ray , out hit ) ) {
				
			}
		}

		if ( Input.GetMouseButton ( 0 ) ) {
			RaycastHit hit;
			Ray ray = camera.ScreenPointToRay ( Input.mousePosition );

			if ( Physics.Raycast ( ray , out hit ) ) {
				Transform objectHit = hit.transform;
				Unit unitHit = objectHit.GetComponent<Unit> ();
				if ( unitHit != null ) {
					if ( unitHit as SoldierUnit != null ) {
						unitHit.Select ();
						AddUnit ( unitHit , selectedFriendlyUnits );
					}
				} else {
					ClearSelectedUnits ();
				}
			} else {
				ClearSelectedUnits ();
			}
		}
	}

	private void ClearSelectedUnits() {
		foreach ( Unit unit in selectedFriendlyUnits ) {
			unit.DeSelect ();
		}
		selectedFriendlyUnits.Clear ();
	}

	private void AddUnit( Unit unit , List<Unit> unitList ) {
		unitList.Add ( unit );

	}
}
