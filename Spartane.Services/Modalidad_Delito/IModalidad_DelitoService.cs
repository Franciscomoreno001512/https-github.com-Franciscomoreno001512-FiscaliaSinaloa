using System;
using Spartane.Core.Domain.Modalidad_Delito;
using System.Collections.Generic;
using Spartane.Core.Domain.Data;

namespace Spartane.Services.Modalidad_Delito
{
    /// <summary>
    /// Authentificated Service
    /// </summary>
    public partial interface IModalidad_DelitoService
    {
        Int32 SelCount();
        IList<Spartane.Core.Domain.Modalidad_Delito.Modalidad_Delito> SelAll(Boolean ConRelaciones);
        IList<Spartane.Core.Domain.Modalidad_Delito.Modalidad_Delito> SelAllComplete(Boolean ConRelaciones);
        IList<Spartane.Core.Domain.Modalidad_Delito.Modalidad_Delito> SelAll(Boolean ConRelaciones, Int32 CurrentRecordInt32, Int32 RecordsDisplayedInt32);
        Spartane.Core.Domain.Modalidad_Delito.Modalidad_Delito GetByKey(short Key, Boolean ConRelaciones);
        bool Delete(short Key, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        Int16 Insert(Spartane.Core.Domain.Modalidad_Delito.Modalidad_Delito entity, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        Int16 Update(Spartane.Core.Domain.Modalidad_Delito.Modalidad_Delito entity, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        IList<Spartane.Core.Domain.Modalidad_Delito.Modalidad_Delito> SelAll(Boolean ConRelaciones, string Where, string Order);
        IList<Spartane.Core.Domain.Modalidad_Delito.Modalidad_Delito> ListaSelAll(Boolean ConRelaciones, string Where, string Order);
        Spartane.Core.Domain.Modalidad_Delito.Modalidad_DelitoPagingModel ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order);
        int ListaSelAllCount(string Where);
        IList<Spartane.Core.Domain.Modalidad_Delito.Modalidad_Delito> ListaSelAll(Boolean ConRelaciones, string Where);
    }
}
