using UnityEngine;

namespace ATCNK.ScriptableObjectArchitecture
{
    public abstract class BaseReference<T, TVariable> where TVariable : BaseVariable<T>
    {
        [SerializeField] private TVariable _variable;
        [SerializeField] private bool _useConstant;
        [SerializeField] private T _constantValue;

        public T Value
        {
            get => (_useConstant) ? _constantValue : _variable.Value;
            set
            {
                _variable.Value = value;
                _variable.Invoke();
            }
        }

        public GameEvent Event { get => _variable; }
    }
}