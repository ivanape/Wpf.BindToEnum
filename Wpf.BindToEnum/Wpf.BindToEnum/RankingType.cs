using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wpf.BindToEnum
{
    public enum RankingType
    {
        [Description("Semana")]
        Week,
        [Description("Mes")]
        Month,
        [Description("Año")]
        Year
    }
}
