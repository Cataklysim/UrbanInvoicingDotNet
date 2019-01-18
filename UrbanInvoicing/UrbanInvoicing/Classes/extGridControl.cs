using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UrbanInvoicing.Classes
{
    public static class extGridControl
    {

        public static T GetEntity<T>(this DataGridView pGridView, int pRowIndex)
        {
            T entity = default(T);

            if (pGridView != null)
            {
                object item = (pGridView.Rows[pRowIndex]).DataBoundItem;
                if (item is T)
                    entity = (T)item;

            }

            return entity;
        }
        public static T GetFocusedEntity<T>(this DataGridView pGridView)
        {
            T entity = default(T);

            if (pGridView != null)
            {
                object item = pGridView.SelectedRows[0].DataBoundItem;
                if (item is T)
                    entity = (T)item;
            }

            return entity;
        }



        public static List<T> GetAllEntities<T>(this DataGridView pGridView)
        {
            List<T> entities = new List<T>();

            //Get all open grid views

            for (int i = 0; i < pGridView.RowCount; i++)
            {
                object item = pGridView.Rows[i].DataBoundItem;
                if (item is T)
                    entities.Add((T)item);
            }

            return entities;
        }
    }
}
