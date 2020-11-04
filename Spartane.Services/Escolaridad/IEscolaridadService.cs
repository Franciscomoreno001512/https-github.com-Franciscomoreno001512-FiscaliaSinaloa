using System;
using Spartane.Core.Domain.Escolaridad;
using System.Collections.Generic;
using Spartane.Core.Domain.Data;

namespace Spartane.Services.Escolaridad
{
    /// <summary>
    /// Authentificated Service
    /// </summary>
    public partial interface IEscolaridadService
    {
        Int32 SelCount();
        IList<Spartane.Core.Domain.Escolaridad.Escolaridad> SelAll(Boolean ConRelaciones);
        IList<Spartane.Core.Domain.Escolaridad.Escolaridad> SelAllComplete(Boolean ConRelaciones);
        IList<Spartane.Core.Domain.Escolaridad.Escolaridad> SelAll(Boolean ConRelaciones, Int32 CurrentRecordInt32, Int32 RecordsDisplayedInt32);
        Spartane.Core.Domain.Escolaridad.Escolaridad GetByKey(short Key, Boolean ConRelaciones);
        bool Delete(short Key, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        Int16 Insert(Spartane.Core.Domain.Escolaridad.Escolaridad entity, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        Int16 Update(Spartane.Core.Domain.Escolaridad.Escolaridad entity, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        IList<Spartane.Core.Domain.Escolaridad.Escolaridad> SelAll(Boolean ConRelaciones, string Where, string Order);
        IList<Spartane.Core.Domain.Escolaridad.Escolaridad> ListaSelAll(Boolean ConRelaciones, string Where, string Order);
        Spartane.Core.Domain.Escolaridad.EscolaridadPagingModel ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order);
        int ListaSelAllCount(string Where);
        IList<Spartane.Core.Domain.Escolaridad.Escolaridad> ListaSelAll(Boolean ConRelaciones, string Where);
    }
}
