using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using System.Collections;

using System.Reflection;

namespace TraderLight
{
    public partial class BoundListView : ListView
    {
        public BoundListView()
        {
            InitializeComponent();
            this.View = View.Details;
            this.FullRowSelect = true;
        }

        /// <summary>
        /// Reloads listView with data from datasource. 
        /// </summary>
        /// <param name="dataSource"></param>
        public void ReloadListViewData(IList dataSource)
        {
            this.Items.Clear();
            foreach (object obj in dataSource)
            {
                AddRowToListView(obj);
            }
        }

        /// <summary>
        /// Adds item to listView from object's properties. (its find match property name from the appropriate listView's column's tag)
        /// </summary>
        /// <param name="obj">object to add</param>
        private void AddRowToListView(object obj)
        {
            ListViewItem item = new ListViewItem();
            item.Tag = obj;

            Type type = obj.GetType();
            
            string propertyName = string.Empty;
            foreach (ColumnHeader columnHeader in this.Columns)
            {
                propertyName = columnHeader.Tag as string;
                if (string.IsNullOrEmpty(propertyName))
                    continue;

                PropertyInfo pi = type.GetProperty(propertyName);
                if (pi == null)
                    continue;

                object val = pi.GetValue(obj,null);

                item.SubItems.Add(val.ToString());
            }
            this.Items.Add(item);
        }


    }
}
