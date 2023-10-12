using TemplatePattern;
using TemplatePattern.Tasks;

// Using tasks enforces that some specific set of operations always be performed when the task is executed. In this
// case, an audit is recorded.

AuditTrail auditTrail = new AuditTrail();

// Perform a task to open a bank account.
OpenAccountTask openAccountTask = new OpenAccountTask(auditTrail);
// Prints "Audit Recorded" on one line, then prints "Account Opened" on the next line.
openAccountTask.Execute();

// Perform a task to transfer money.
TransferMoneyTask transferMoneyTask = new TransferMoneyTask(auditTrail);
// Prints "Audit Recorded" on one line, then prints "Money Transferred" on the next line.
transferMoneyTask.Execute();

// Perform a task to close a bank account.
CloseAccountTask closeAccountTask = new CloseAccountTask(auditTrail);
// Prints "Audit Recorded" on one line, then prints "Account Closed" on the next line.
closeAccountTask.Execute();