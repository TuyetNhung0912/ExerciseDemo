namespace ExerciseDemo.Domain.Entities
{
    public class Product
    {
        public int SupId { get; set; } = 0;
        public int ReturnResultId { get; set; } = 0;
        public string Contract { get; set; } = string.Empty;
        public int ObjId { get; set; } = 0;
        public int Status { get; set; } = 0;
        public int Flag { get; set; } = 0;
        public string AccountNotOk { get; set; } = string.Empty;
        public DateTime? ReturnDate { get; set; }
        public string ReturnCause { get; set; } = string.Empty;
        public string DepartmentName { get; set; } = string.Empty;
        public string AccountTranfer { get; set; } = string.Empty;
        public DateTime? TranferDate { get; set; }
        public string CauseDescription { get; set; } = string.Empty;
        public string AccountCancel { get; set; } = string.Empty;
        public DateTime? CancelDate { get; set; }
        public string TranferDescription { get; set; } = string.Empty;
        public string ReasonCancel { get; set; } = string.Empty;
    }
}
