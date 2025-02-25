using System;

namespace DesignPatterns.Builder_Report
{
    public class Report
    {
        public enum SortingMethod
        {
            BySalesperson,
            ByTaxCategory
        }

        private readonly DateTime _fromDate;
        private readonly DateTime _toDate;
        private readonly bool _includeReturnedOrders;
        private readonly bool _includeUnshippedOrders;
        private readonly SortingMethod _sortBy;

        public Report(DateTime from, DateTime to, bool includeReturnedOrders, bool includeUnshippedOrders, SortingMethod sortBy)
        {
            _fromDate = from;
            _toDate = to;
            _includeReturnedOrders = includeReturnedOrders;
            _includeUnshippedOrders = includeUnshippedOrders;
            _sortBy = sortBy;
        }

        public object CreatePDFReport()
        {
            // Pretend this object is a PDF report, 
            // built for the sales that match the passed-in constructor parameters.
            return new object();
        }
    }
}
