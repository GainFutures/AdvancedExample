using System;
using System.Windows.Forms;

namespace OEC.API.Example
{
    /// <summary>
    ///     Displays OSO/OCO order links and provides navigation to the links.
    /// </summary>
    public partial class OrderLinksControl : BaseControl
    {
        /// <summary>
        ///     Constructs OrderLinksControl.
        /// </summary>
        public OrderLinksControl()
        {
            InitializeComponent();
        }

        /// <summary>
        ///     Occurs when some order link is clicked.
        /// </summary>
        public event OrderLinkNavigatedEventHandler OrderLinkNavigated;

        /// <summary>
        ///     Updates order links for a specified order.
        /// </summary>
        /// <param name="order">Source for links</param>
        public void UpdateOrder(Order order)
        {
            pnlLayout.Controls.Clear();
            if (order == null)
            {
                return;
            }

            CreateLinkControl("Current Order: ", order);

            if (order.Parent != null)
            {
                CreateLinkControl("Linked Parent: ", order.Parent);
            }

            if (order.Linked != null)
            {
                if (order.Linked.OCO != null)
                {
                    CreateLinkControl("Linked OCO 1: ", order.Linked);
                    CreateLinkControl("Linked OCO 2: ", order.Linked.OCO);
                }
                else
                {
                    CreateLinkControl("Single Linked: ", order.Linked);
                }
            }

            if (order.OCO != null)
            {
                CreateLinkControl("OCO Sibling: ", order.OCO);
            }
        }

        /// <summary>
        ///     Creates LinkLabel control for a specified order.
        /// </summary>
        /// <param name="text">Caption of link</param>
        /// <param name="target">Target order where the link will navigate.</param>
        private void CreateLinkControl(string text, Order target)
        {
            if (string.IsNullOrEmpty(text) || target == null)
            {
                return;
            }

            string s = target.ID + ", " + target;
            var link = new LinkLabel
            {
                Text = text + s,
                LinkArea = new LinkArea(text.Length, s.Length),
                AutoSize = true
            };
            link.Click += Link_Click;
            link.Tag = target;

            pnlLayout.Controls.Add(link);
        }

        /// <summary>
        ///     Handles clicking link control and raises OrderLinkNavigated event.
        /// </summary>
        private void Link_Click(object sender, EventArgs e)
        {
            var link = sender as LinkLabel;

            if (OrderLinkNavigated != null)
            {
                if (link != null) OrderLinkNavigated(link.Tag as Order);
            }
        }
    }

    /// <summary>
    ///     Declares OrderLinkNavigated event handler.
    /// </summary>
    /// <param name="target">Navigation target</param>
    public delegate void OrderLinkNavigatedEventHandler(Order target);
}