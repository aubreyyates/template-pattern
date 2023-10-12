namespace TemplatePattern.Tasks
{
    /// <summary>
    /// The OpenAccountTask class is used to open bank accounts.
    /// </summary>
    public class OpenAccountTask : Task
    {
        /// <summary>
        /// The constructor passes the AuditTrail to the parent class.
        /// </summary>
        /// <param name="auditTrail">the AuditTrail.</param>
        public OpenAccountTask(AuditTrail auditTrail) : base(auditTrail)
        {
        }

        /// <summary>
        /// Performs the account open.
        /// </summary>
        protected override void DoExecute()
        {
            Console.WriteLine("Account Opened");
        }
    }
}
