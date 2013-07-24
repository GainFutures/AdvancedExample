using System;
using System.Windows.Forms;

namespace OEC.API.Example
{
    /// <summary>
    ///     Chat control. Provides send/receive chat messages functionality. Displays available user list
    /// </summary>
    public partial class ChatControl : BaseControl
    {
        /// <summary>
        ///     Chat control constructor
        /// </summary>
        public ChatControl()
        {
            InitializeComponent();
        }

        /// <summary>
        ///     Prepares chat control related events
        /// </summary>
        protected override void PrepareControlEventHandlers()
        {
            base.PrepareControlEventHandlers();
            OECClient.Global.OnUserMessage += OnUserMessage;
            OECClient.Global.OnUserStatusChanged += Global_OnUserStatusChanged;
            OECClient.Global.OnLoginComplete += OnLoginComplete;
        }

        /// <summary>
        ///     Occurs when user status is changed, refreshes user list
        /// </summary>
        /// <param name="status"></param>
        private void Global_OnUserStatusChanged(User status)
        {
            RefreshUsers();
        }

        /// <summary>
        ///     Refreshes events and user list when login complete
        /// </summary>
        private void OnLoginComplete()
        {
            RefreshUsers();
            RefreshMessages();
        }

        /// <summary>
        ///     Refreshes all messages
        /// </summary>
        private void RefreshMessages()
        {
            lbMessagesLog.Items.Clear();

            foreach (ChatMessage message in OECClient.Global.Chat)
            {
                // if system message, do not output timestamp
                string time;
                if (message.Timestamp.Ticks == 0)
                    time = string.Empty;
                else
                    time = message.Timestamp.ToShortDateString() + " " + message.Timestamp.ToShortTimeString();

                lbMessagesLog.Items.Add(string.Format("{0} {1} : {2}", time,
                    (message.Incoming ? "" : "To ") + message.User, message.Message));
            }
        }

        /// <summary>
        ///     refreshes list of users
        /// </summary>
        private void RefreshUsers()
        {
            var userList = new User[OECClient.Global.Users.Count];
            OECClient.Global.Users.Values.CopyTo(userList, 0);
            lbUsers.DataSource = userList;
        }

        /// <summary>
        ///     Occurs when new message added to Messages list
        /// </summary>
        private void OnUserMessage(User user, string message)
        {
            RefreshMessages();
        }

        /// <summary>
        ///     Sends message
        /// </summary>
        private void btSend_Click(object sender, EventArgs e)
        {
            if (OECClient.Global.ConnectionClosed)
                return;

            if (lbUsers.SelectedItem == null)
                return;

            if (edMessage.Text.Trim() == string.Empty)
                return;

            var user = (User) lbUsers.SelectedItem;
            OECClient.Global.SendMessage(user, edMessage.Text);
            RefreshMessages();
            edMessage.Text = string.Empty;
        }

        /// <summary>
        ///     formats user list output, makes (+) prefix for online users and (-) for offline
        /// </summary>
        private void lbUsers_Format(object sender, ListControlConvertEventArgs e)
        {
            var userItem = (User) e.ListItem;
            e.Value = (userItem.Online ? "(+)" : "(-)") + e.Value;
        }
    }
}