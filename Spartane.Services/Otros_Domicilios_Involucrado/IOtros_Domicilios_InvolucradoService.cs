using System;
using Spartane.Core.Domain.Otros_Domicilios_Involucrado;
using System.Collections.Generic;
using Spartane.Core.Domain.Data;

namespace Spartane.Services.Otros_Domicilios_Involucrado
{
    /// <summary>
    /// Authentificated Service
    /// </summary>
    public partial interface IOtros_Domicilios_InvolucradoService
    {
        Int32 SelCount();
        IList<Spartane.Core.Domain.Otros_Domicilios_Involucrado.Otros_Domicilios_Involucrado> SelAll(Boolean ConRelaciones);
        IList<Spartane.Core.Domain.Otros_Domicilios_Involucrado.Otros_Domicilios_Involucrado> SelAllComplete(Boolean ConRelaciones);
        IList<Spartane.Core.Domain.Otros_Domicilios_Involucrado.Otros_Domicilios_Involucrado> SelAll(Boolean ConRelaciones, Int32 CurrentRecordInt32, Int32 RecordsDisplayedInt32);
        Spartane.Core.Domain.Otros_Domicilios_Involucrado.Otros_Domicilios_Involucrado GetByKey(int Key, Boolean ConRelaciones);
        bool Delete(int Key, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        Int32 Insert(Spartane.Core.Domain.Otros_Domicilios_Involucrado.Otros_Domicilios_Involucrado entity, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        Int32 Update(Spartane.Core.Domain.Otros_Domicilios_Involucrado.Otros_Domicilios_Involucrado entity, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        IList<Spartane.Core.Domain.Otros_Domicilios_Involucrado.Otros_Domicilios_Involucrado> SelAll(Boolean ConRelaciones, string Where, string Order);
        IList<Spartane.Core.Domain.Otros_Domicilios_Involucrado.Otros_Domicilios_Involucrado> ListaSelAll(Boolean ConRelaciones, string Where, string Order);
        Spartane.Core.Domain.Otros_Domicilios_Involucrado.Otros_Domicilios_InvolucradoPagingModel ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order);
        int ListaSelAllCount(string Where);
        IList<Spartane.Core.Domain.Otros_Domicilios_Involucrado.Otros_Domicilios_Involucrado> ListaSelAll(Boolean ConRelaciones, string Where);
    }
}
