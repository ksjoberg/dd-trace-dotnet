namespace Datadog.Trace
{
    internal interface IScopeManager
    {
        Scope Active { get; }

        Scope Activate(Span span, bool finishOnClose);

        void Close(Scope scope);
    }
}
