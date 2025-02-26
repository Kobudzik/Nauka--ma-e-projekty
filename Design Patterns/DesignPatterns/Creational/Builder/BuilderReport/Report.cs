using System;

namespace BuilderReport;

public class Report(DateTime from, DateTime to, bool includeReturnedOrders, bool includeUnshippedOrders, SortingMethod sortBy)
{
    private readonly DateTime _fromDate = from;
    private readonly DateTime _toDate = to;
    private readonly bool _includeReturnedOrders = includeReturnedOrders;
    private readonly bool _includeUnshippedOrders = includeUnshippedOrders;
    private readonly SortingMethod _sortBy = sortBy;

    public object CreatePDFReport()
    {
        // Pretend this object is a PDF report,
        // built for the sales that match the passed-in constructor parameters.
        return new object();
    }
}
