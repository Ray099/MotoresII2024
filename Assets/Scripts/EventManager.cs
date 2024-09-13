using System;
using System.Collections.Generic;
using UnityEngine;

public class EventManager 
{
    static EventManager m_instance;

    public static EventManager m_Instance
    {
        get
        {
            if (m_instance == null)
            {
                m_instance = new EventManager();
            }
            return m_instance;
        }
    }

    public delegate void EventDelegate<T>(T e) where T : GameEvent;

    readonly Dictionary<Type, Delegate> _delegates = new Dictionary<Type, Delegate>();

    public void AddListener<T>(EventDelegate<T> _listener) where T: GameEvent
    {
        Delegate outDelegate;

        if(_delegates.TryGetValue(typeof(T), out outDelegate))
        {
            _delegates[typeof(T)] = Delegate.Combine(outDelegate, _listener);
        }
        else
        {
            _delegates[typeof(T)] = _listener;
        }
    }

   
    public void InvokeEvent<T>(T _event) where T : GameEvent
    {
        if (_event == null)
        {
            throw new ArgumentNullException("Event of name " + _event + " is null");
        }

        Delegate outDelegate;
        if(_delegates.TryGetValue(typeof(T), out outDelegate))
        {
            EventDelegate<T> callback = outDelegate as EventDelegate<T>;
            if (callback != null)
            {
                callback(_event);
            }
        }
    }
    public void ResetEventManager()
    {
        _delegates.Clear();
    }

 
}
