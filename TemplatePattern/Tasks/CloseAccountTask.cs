namespace TemplatePattern.Tasks
{
    public class CloseAccountTask : Task
    {
        public CloseAccountTask(AuditTrail auditTrail) : base(auditTrail)
        {
        }

        protected override void DoExecute()
        {
            Console.WriteLine("Account Closed");
        }
    }
}
