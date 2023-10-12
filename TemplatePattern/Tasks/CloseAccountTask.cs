namespace TemplatePattern.Tasks
{
    /// <summary>
    /// The CloseAccountTask class is used to close bank accounts.
    /// </summary>
    public class CloseAccountTask : Task
    {
        /// <summary>
        /// The constructor passes the AuditTrail to the parent class.
        /// </summary>
        /// <param name="auditTrail">the AuditTrail.</param>
        public CloseAccountTask(AuditTrail auditTrail) : base(auditTrail)
        {
        }

        /// <summary>
        /// Performs the account close.
        /// </summary>
        protected override void DoExecute()
        {
            Console.WriteLine("Account Closed");
        }
    }
}
