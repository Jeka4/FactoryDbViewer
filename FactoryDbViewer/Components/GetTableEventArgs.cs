using System;

namespace FactoryDbViewer.Components
{
    public class GetTableEventArgs : EventArgs
    {
        public TableTypes TableType { get; set; }

        public GetTableEventArgs(TableTypes tableType)
        {
            TableType = tableType;
        }
    }
}
