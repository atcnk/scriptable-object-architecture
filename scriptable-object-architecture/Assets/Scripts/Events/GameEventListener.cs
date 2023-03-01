using UnityEngine.Events;

namespace ATCNK.ScriptableObjectArchitecture
{
    public class GameEventListener
    {
        public GameEvent Event;
        public UnityEvent Response = new UnityEvent();

        public GameEventListener(GameEvent gameEvent, UnityAction unityAction)
        {
            Event = gameEvent;
            Response.AddListener(unityAction);
        }

        private void OnEnable() => Event.RegisterListener(this);
        private void OnDisable() => Event.UnregisterListener(this);

        public void OnEventRaised() => Response.Invoke();
    }
}
