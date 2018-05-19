namespace UrbanInvoicing.Classes
{
    public class clsSystemstatus
    {
        public int Id { get; set; }
        public string name { get; set; }

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