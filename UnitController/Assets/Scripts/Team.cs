using System.Collections.Generic;

[System.Serializable]
public class Team {
	public List<Unit> units;

	public Team() {
		units = new List<Unit> ();
	}

	public void AddUnit( Unit unit ) {
		units.Add ( unit );
	}

	public bool TeamContainsUnit( Unit unit ) {
		return units.Contains ( unit );
	}

	public void RemoveUnit( Unit unit ) {
		if ( units.Contains ( unit ) )
			units.Remove ( unit );
	}
}