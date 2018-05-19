namespace UrbanInvoicing.Classes
{
    public class clsSystemstatus
    {
        int Id;
        string name;

        public clsSystemstatus() { }

        public clsSystemstatus(enmSystemstatus pEnm)
        {
            this.Id = (int)pEnm;
            this.name = pEnm.ToString();
        }

        public enum enmSystemstatus
        {
            Created = 1,
            Deleted = 11
        }
    }
}