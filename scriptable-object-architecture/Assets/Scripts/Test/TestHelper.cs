using UnityEngine;
using ATCNK.ScriptableObjectArchitecture;

namespace ATCNK
{
    public class TestHelper : MonoBehaviour
    {
        [SerializeField] private GameEvent _testGameEvent;
        [SerializeField] private IntReference _testIntReference;

        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.X))
            {
                _testGameEvent.Invoke();
            }

            if (Input.GetKeyDown(KeyCode.Z))
            {
                _testIntReference.Value++;
            }
        }

        public void TestA()
        {
            Debug.Log("Test A.");
        }

        public void TestB()
        {
            Debug.Log("Test B.");
        }

        public void TestC()
        {
            Debug.Log("Test C.");
        }

        public void OnTestIntReferenceChange()
        {
            Debug.Log("Test Int Reference's value is changed to: " + _testIntReference.Value);
        }
    }
}