using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Setup : MonoBehaviour
{
    static List<Handler> handlers;

    TeamHandler teamHandler;
    InputHandler inputHandler;

    private void Awake() {
        teamHandler = GetComponent<TeamHandler> ();
        inputHandler = GetComponent<InputHandler> ();

        teamHandler.Initialize ();
        inputHandler.Initialize ( teamHandler );
        
        handlers = new List<Handler> ( GetComponents<Handler> () );

        foreach ( Handler handler in handlers ) {
            handler.Initialize ();
        }

    }

    public static Handler GetHandlerOfType<T>( T type ) {
        Handler returnHandler = handlers[0];
        foreach ( Handler handler in handlers ) {
            if ( handler.GetType() == type.GetType() ) {
                returnHandler = handler;
            }
        }
        return returnHandler;
    }
}
