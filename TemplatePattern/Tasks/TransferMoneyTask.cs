namespace TemplatePattern.Tasks
{
    /// <summary>
    /// The TransferMoneyTask class is used to transfer money from one account to another.
    /// </summary>
    public class TransferMoneyTask : Task
    {
        /// <summary>
        /// The constructor passes the AuditTrail to the parent class.
        /// </summary>
        /// <param name="auditTrail">the AuditTrail.</param>
        public TransferMoneyTask(AuditTrail auditTrail) : base(auditTrail)
        {
        }

        /// <summary>
        /// Performs the transfer of money from one account to another.
        /// </summary>
        protected override void DoExecute()
        {
            Console.WriteLine("Money Transferred");
        }
    }
}
