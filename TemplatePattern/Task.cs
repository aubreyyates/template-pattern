namespace TemplatePattern
{
    /// <summary>
    /// The Task class is an abstract class that all task classes must inherit from. This will allow standard 
    /// operations to be performed when the task is executed.
    /// </summary>
    public abstract class Task
    {
        /// <summary>
        /// The AuditTrail.
        /// </summary>
        private AuditTrail AuditTrail;

        /// <summary>
        /// The contructor sets an AuditTrail.
        /// </summary>
        /// <param name="auditTrail">The AuditTrail.</param>
        public Task(AuditTrail auditTrail) 
        {
            AuditTrail = auditTrail;
        }

        /// <summary>
        /// Executes the standard operations and the task.
        /// </summary>
        public void Execute()
        {
            AuditTrail.Record();
            DoExecute();
        }

        /// <summary>
        /// Executes the task.
        /// </summary>
        protected abstract void DoExecute();
    }
}
