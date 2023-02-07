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
    public partial class MainSceneView : UserControl
    {
        public MainSceneView()
        {
            InitializeComponent();

            this.DataContext = new MainSceneModel();

            var testControl = new TestControl();
            topPanel.Children.Add(testControl);

            testControl.DataContext = new TestControlModel();
        }

#if NOESIS
        StackPanel topPanel => FindName(nameof(topPanel)) as StackPanel;
        StackPanel dataPanel => FindName(nameof(dataPanel)) as StackPanel;

        private void InitializeComponent()
        {
            NoesisUnity.LoadComponent(this);
        }
#endif
    }
}
