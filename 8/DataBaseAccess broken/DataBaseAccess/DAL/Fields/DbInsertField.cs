namespace GhostRider.DataBaseAccess.DAL.Fields
{
    public class DbInsertField : DbField
    {
        public DbInsertField() : base(default (object))
        {

        }


        public DbInsertField(object fieldValue) : base(fieldValue)
        {
        }

        public bool IsFilled { get; private set; }

        public override object FieldValue
        {
            get
            {
                return fieldValue;
            }
            set
            {
                fieldValue = value;
                IsFilled = true;
            }
        }

        protected object fieldValue;
    }
}
