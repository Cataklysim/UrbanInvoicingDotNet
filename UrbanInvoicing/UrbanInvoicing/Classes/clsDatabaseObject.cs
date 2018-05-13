using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UrbanInvoicing.Classes
{
    abstract class clsDatabaseObject : clsSystemstatus
    {
        DateTime addedAt;
        DateTime editedAt;

        clsSystemstatus systemstatus;

        public abstract bool Save();
        public abstract void Load();

        protected void Delete()
        {
            this.systemstatus = new clsSystemstatus(clsSystemstatus.enmSystemstatus.Deleted);
            this.editedAt = DateTime.Now;
        }

    }