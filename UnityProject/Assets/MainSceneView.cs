#if UNITY_5_3_OR_NEWER
#define NOESIS
using Noesis;
#else
using System;
using System.Windows.Controls;
#endif


using System.Windows.Input;
using UnityEngine;

namespace UnityProject
{
    class MainSceneView : MonoBehaviour
    {
#if NOESIS
        public NoesisEventCommand StartCommand;
#endif

#if NOESIS
        void Start()
        {

            StartCommand.AddListener(OnStart);
            NoesisView view = GetComponent<NoesisView>();
            view.Content.DataContext = this;
        }
#endif

        public static void OnStart(object obj)
        {
            
#if NOESIS
            Debug.Log("Start");
#else
            Console.WriteLine("Start");
#endif

        }
    }

#if NOESIS
    public class DelegateCommand : NoesisEventCommand
    {

    }
#else
    public class DelegateCommand : ICommand
    {
        public DelegateCommand(Action<object> execute)
        {
            if (execute == null)
            {
                throw new ArgumentNullException("execute");
            }

            _execute = execute;
        }

        public DelegateCommand(Func<object, bool> canExecute, Action<object> execute)
        {
            if (canExecute == null)
            {
                throw new ArgumentNullException("canExecute");
            }
            if (execute == null)
            {
                throw new ArgumentNullException("execute");
            }

            _canExecute = canExecute;
            _execute = execute;
        }

        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
            return _canExecute == null || _canExecute(parameter);
        }

        public void Execute(object parameter)
        {
            _execute(parameter);
        }

        public void RaiseCanExecuteChanged()
        {
            var handler = CanExecuteChanged;
            if (handler != null)
            {
                handler(this, System.EventArgs.Empty);
            }
        }

        private Func<object, bool> _canExecute;
        private Action<object> _execute;
    }
#endif
}
