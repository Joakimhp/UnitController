using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeamHandler : Handler
{
	public Team friendlyTeam;
	public Team enemyTeam;

	public override void Initialize() {
		friendlyTeam = new Team ();
		enemyTeam = new Team ();
	}
}
