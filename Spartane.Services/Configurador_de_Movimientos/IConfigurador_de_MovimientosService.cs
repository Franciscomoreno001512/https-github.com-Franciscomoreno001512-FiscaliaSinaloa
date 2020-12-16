using System;
using Spartane.Core.Domain.Configurador_de_Movimientos;
using System.Collections.Generic;
using Spartane.Core.Domain.Data;

namespace Spartane.Services.Configurador_de_Movimientos
{
    /// <summary>
    /// Authentificated Service
    /// </summary>
    public partial interface IConfigurador_de_MovimientosService
    {
        Int32 SelCount();
        IList<Spartane.Core.Domain.Configurador_de_Movimientos.Configurador_de_Movimientos> SelAll(Boolean ConRelaciones);
        IList<Spartane.Core.Domain.Configurador_de_Movimientos.Configurador_de_Movimientos> SelAllComplete(Boolean ConRelaciones);
        IList<Spartane.Core.Domain.Configurador_de_Movimientos.Configurador_de_Movimientos> SelAll(Boolean ConRelaciones, Int32 CurrentRecordInt32, Int32 RecordsDisplayedInt32);
        Spartane.Core.Domain.Configurador_de_Movimientos.Configurador_de_Movimientos GetByKey(int Key, Boolean ConRelaciones);
        bool Delete(int Key, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        Int32 Insert(Spartane.Core.Domain.Configurador_de_Movimientos.Configurador_de_Movimientos entity, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        Int32 Update(Spartane.Core.Domain.Configurador_de_Movimientos.Configurador_de_Movimientos entity, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        IList<Spartane.Core.Domain.Configurador_de_Movimientos.Configurador_de_Movimientos> SelAll(Boolean ConRelaciones, string Where, string Order);
        IList<Spartane.Core.Domain.Configurador_de_Movimientos.Configurador_de_Movimientos> ListaSelAll(Boolean ConRelaciones, string Where, string Order);
        Spartane.Core.Domain.Configurador_de_Movimientos.Configurador_de_MovimientosPagingModel ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order);
        int ListaSelAllCount(string Where);
        IList<Spartane.Core.Domain.Configurador_de_Movimientos.Configurador_de_Movimientos> ListaSelAll(Boolean ConRelaciones, string Where);
    }
}
