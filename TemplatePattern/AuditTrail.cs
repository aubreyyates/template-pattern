namespace TemplatePattern
{
    /// <summary>
    /// The AuditTrail class is used to record audits of tasks that occur.
    /// </summary>
    public class AuditTrail
    {
        /// <summary>
        /// Records an audit of a task.
        /// </summary>
        public void Record()
        {
            Console.WriteLine("Audit Recorded");
        }
    }
}
