using System.ComponentModel;

namespace FactoryDbViewer.Components
{
    public enum TableTypes
    {
        [Description("Неопределённый")]
        Undefined,
        [Description("Таблица рабочих")]
        Workers,
        [Description("Таблица специальностей")]
        Specialities,
        [Description("Таблица цехов")]
        Departments,
        [Description("Таблица ежедневных отчётов")]
        DailyAccounts,
        [Description("Таблица ежемесячных отчётов")]
        MonthAccounts
    }
}
