using Avalonia;
using Avalonia.Controls;

namespace BioParallel.Views;

public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
        this.AttachDevTools();
    }
}