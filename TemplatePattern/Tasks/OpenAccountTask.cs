namespace TemplatePattern.Tasks
{
    public class OpenAccountTask : Task
    {
        public OpenAccountTask(AuditTrail auditTrail) : base(auditTrail)
        {
        }

        protected override void DoExecute()
        {
            Console.WriteLine("Account Opened");
        }
    }
}
