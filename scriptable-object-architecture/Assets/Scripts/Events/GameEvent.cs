using System.Collections.Generic;
using UnityEngine;

namespace ATCNK.ScriptableObjectArchitecture
{
    [CreateAssetMenu(menuName = Utility.VARIABLE_SUBMENU + "Game Event", order = 0)]
    public class GameEvent : ScriptableObject
    {
        private List<GameEventListener> _listeners = new List<GameEventListener>();
        private List<GameEventListenerComponent> _componentListeners = new List<GameEventListenerComponent>();

        public void RegisterListener(GameEventListener listener) => _listeners.Add(listener);
        public void RegisterListener(GameEventListenerComponent listener) => _componentListeners.Add(listener);
        public void UnregisterListener(GameEventListener listener) => _listeners.Remove(listener);
        public void UnregisterListener(GameEventListenerComponent listener) => _componentListeners.Remove(listener);
        public void Invoke()
        {
            for (int i = _componentListeners.Count - 1; i >= 0; i--)
            {
                _componentListeners[i].OnEventRaised();
            }

            for (int i = _listeners.Count - 1; i >= 0; i--)
            {
                _listeners[i].OnEventRaised();
            }
        }

        public bool IsNull() => (_componentListeners.Count == 0) && (_listeners.Count == 0);
    }
}