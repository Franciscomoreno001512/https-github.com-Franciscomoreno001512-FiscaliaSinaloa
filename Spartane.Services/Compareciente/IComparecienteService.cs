using System;
using Spartane.Core.Domain.Compareciente;
using System.Collections.Generic;
using Spartane.Core.Domain.Data;

namespace Spartane.Services.Compareciente
{
    /// <summary>
    /// Authentificated Service
    /// </summary>
    public partial interface IComparecienteService
    {
        Int32 SelCount();
        IList<Spartane.Core.Domain.Compareciente.Compareciente> SelAll(Boolean ConRelaciones);
        IList<Spartane.Core.Domain.Compareciente.Compareciente> SelAllComplete(Boolean ConRelaciones);
        IList<Spartane.Core.Domain.Compareciente.Compareciente> SelAll(Boolean ConRelaciones, Int32 CurrentRecordInt32, Int32 RecordsDisplayedInt32);
        Spartane.Core.Domain.Compareciente.Compareciente GetByKey(int Key, Boolean ConRelaciones);
        bool Delete(int Key, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        Int32 Insert(Spartane.Core.Domain.Compareciente.Compareciente entity, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        Int32 Update(Spartane.Core.Domain.Compareciente.Compareciente entity, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        IList<Spartane.Core.Domain.Compareciente.Compareciente> SelAll(Boolean ConRelaciones, string Where, string Order);
        IList<Spartane.Core.Domain.Compareciente.Compareciente> ListaSelAll(Boolean ConRelaciones, string Where, string Order);
        Spartane.Core.Domain.Compareciente.ComparecientePagingModel ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order);
        int ListaSelAllCount(string Where);
        IList<Spartane.Core.Domain.Compareciente.Compareciente> ListaSelAll(Boolean ConRelaciones, string Where);
    }
}
