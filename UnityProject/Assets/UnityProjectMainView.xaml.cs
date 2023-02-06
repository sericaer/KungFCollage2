#if UNITY_5_3_OR_NEWER
#define NOESIS
using Noesis;
#else
using System;
using System.Windows.Controls;
#endif

namespace UnityProject
{
    /// <summary>
    /// Interaction logic for UnityProjectMainView.xaml
    /// </summary>
    public partial class UnityProjectMainView : UserControl
    {
        public UnityProjectMainView()
        {
            InitializeComponent();
        }

#if NOESIS
        private void InitializeComponent()
        {
            NoesisUnity.LoadComponent(this);
        }
#endif
    }
}
