namespace ATCNK.ScriptableObjectArchitecture
{
    public abstract class BaseVariable<T> : GameEvent
    {
        public T Value;

        private void OnValidate()
        {
            base.Invoke();
        }
    }
}