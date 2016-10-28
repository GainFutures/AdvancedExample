using System;
using System.Windows.Forms;
using OEC.Data;

namespace OEC.API.Example
{
    /// <summary>
    ///     Login form
    /// </summary>
    public partial class LoginForm : Form
    {
        /// <summary>
        ///     Login form constructor. Prepares login related events
        /// </summary>
        public LoginForm()
        {
            InitializeComponent();

            OECClient.CreateInstance(false);
            OECClient.Global.OnLoginComplete += OECClient_OnLoginComplete;
            OECClient.Global.OnLoginFailed += OECClient_OnLoginFailed;
            OECClient.Global.OnDisconnected += OECClient_OnDisconnected;
        }

        /// <summary>
        ///     Event, that occurs when connection status is changed
        /// </summary>
        public event ConnectionStatusChangeEventHandler OnConnectionStatusChange;

        /// <summary>
        ///     Occurs when disconnected from client
        /// </summary>
        /// <param name="unexpected"></param>
        private void OECClient_OnDisconnected(bool unexpected)
        {
            if (unexpected)
                MessageBox.Show("Unexpected disconnection occurs");

            OnConnectionStatusChange(ConnectionStatus.Disconnected);
        }

        /// <summary>
        ///     Occurs when login failed
        /// </summary>
        /// <param name="reason"></param>
        private void OECClient_OnLoginFailed(FailReason reason)
        {
            MessageBox.Show("Login Failed : " + reason);
            OnConnectionStatusChange(ConnectionStatus.Disconnected);
        }

        /// <summary>
        ///     Occurs when login successfull
        /// </summary>
        private void OECClient_OnLoginComplete()
        {
            OnConnectionStatusChange(ConnectionStatus.Connected);
            foreach (BaseContract bc in OECClient.Global.ContractGroups["Indices"].BaseContracts)
                if (bc.IsFuture)
                    OECClient.Global.RequestContracts(bc);
        }

        /// <summary>
        ///     User presses login button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btLogin_Click(object sender, EventArgs e)
        {
            try
            {
                OECClient.Global.Disconnect();
                OnConnectionStatusChange(ConnectionStatus.Connecting);
                OECClient.Global.UUID = "9e61a8bc-0a31-4542-ad85-33ebab0e4e86";
                OECClient.Global.Connect("api.gainfutures.com", 9200, edLogin.Text, edPass.Text, false);
            }
            catch (Exception ex)
            {
                OnConnectionStatusChange(ConnectionStatus.Disconnected);
                MessageBox.Show("Error during connection : " + ex.Message);
                return;
            }

            Close();
        }

        /// <summary>
        ///     Gets connection status comment depends on connection status enumeration
        /// </summary>
        /// <param name="connectionStatus">Connection status to analize</param>
        /// <returns>Return connection status comment</returns>
        public static string GetConnectionStatusInfo(ConnectionStatus connectionStatus)
        {
            switch (connectionStatus)
            {
                case ConnectionStatus.Connected:
                    return "Connected";
                case ConnectionStatus.Connecting:
                    return "Connecting...";
                case ConnectionStatus.Disconnected:
                    return "Disconnected";
                default:
                    throw new ArgumentException("Unknown connection status");
            }
        }
    }


    /// <summary>
    ///     Connection status changed event handler
    /// </summary>
    /// <param name="newConnectionStatus"></param>
    public delegate void ConnectionStatusChangeEventHandler(ConnectionStatus newConnectionStatus);


    /// <summary>
    ///     Connection status enumeration
    /// </summary>
    public enum ConnectionStatus
    {
        /// <summary>
        ///     Connected to server
        /// </summary>
        Connected,

        /// <summary>
        ///     Not connected
        /// </summary>
        Disconnected,

        /// <summary>
        ///     Trying to connect
        /// </summary>
        Connecting
    }
}