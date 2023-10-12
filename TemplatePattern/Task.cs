namespace TemplatePattern
{
    public abstract class Task
    {
        private AuditTrail AuditTrail;

        public Task(AuditTrail auditTrail) 
        {
            AuditTrail = auditTrail;
        }

        public void Execute()
        {
            AuditTrail.Record();
            DoExecute();
        }

        protected abstract void DoExecute();
    }
}
