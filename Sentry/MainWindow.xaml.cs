using System;
using System.Windows;
using System.Windows.Forms;

namespace Sentry
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private NotifyIcon _notifyIcon;
        private SentryDebug _sDebug;
        public MainWindow()
        {
            Setup();
            InitializeComponent();
        }

        private void Setup()
        {
            _sDebug = new SentryDebug();
            _notifyIcon = new NotifyIcon();
            _notifyIcon.BalloonTipText = "Sentry: Small Step Studios";
            _notifyIcon.BalloonTipTitle = "The app";
            _notifyIcon.Text = "The app";
            _notifyIcon.Icon = new System.Drawing.Icon("SentryLogo.ico");
            _notifyIcon.Click += new System.EventHandler(notifyIcon_Click);
            _notifyIcon.Visible = true;
        }

        private void notifyIcon_Click(object sender, EventArgs e)
        {
            this.Activate();
        }

        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            _notifyIcon.Dispose();
            _notifyIcon = null;

            _sDebug.FlushToLog();
            Close();
        }
    }
}
