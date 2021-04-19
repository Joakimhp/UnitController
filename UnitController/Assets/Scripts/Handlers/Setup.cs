using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Setup : MonoBehaviour
{
	List<Handler> handlers;

	private void Awake() {
		handlers = new List<Handler> ( GetComponents<Handler> () );

		foreach ( Handler handler in handlers ) {
			handler.Initialize ();
		}

		
	}
}

public abstract class Handler : MonoBehaviour {
	public abstract void Initialize();
}
