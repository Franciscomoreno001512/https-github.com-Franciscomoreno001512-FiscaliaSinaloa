using System;
using Spartane.Core.Domain.Circunstancias_del_Delito;
using System.Collections.Generic;
using Spartane.Core.Domain.Data;

namespace Spartane.Services.Circunstancias_del_Delito
{
    /// <summary>
    /// Authentificated Service
    /// </summary>
    public partial interface ICircunstancias_del_DelitoService
    {
        Int32 SelCount();
        IList<Spartane.Core.Domain.Circunstancias_del_Delito.Circunstancias_del_Delito> SelAll(Boolean ConRelaciones);
        IList<Spartane.Core.Domain.Circunstancias_del_Delito.Circunstancias_del_Delito> SelAllComplete(Boolean ConRelaciones);
        IList<Spartane.Core.Domain.Circunstancias_del_Delito.Circunstancias_del_Delito> SelAll(Boolean ConRelaciones, Int32 CurrentRecordInt32, Int32 RecordsDisplayedInt32);
        Spartane.Core.Domain.Circunstancias_del_Delito.Circunstancias_del_Delito GetByKey(int Key, Boolean ConRelaciones);
        bool Delete(int Key, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        Int32 Insert(Spartane.Core.Domain.Circunstancias_del_Delito.Circunstancias_del_Delito entity, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        Int32 Update(Spartane.Core.Domain.Circunstancias_del_Delito.Circunstancias_del_Delito entity, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        IList<Spartane.Core.Domain.Circunstancias_del_Delito.Circunstancias_del_Delito> SelAll(Boolean ConRelaciones, string Where, string Order);
        IList<Spartane.Core.Domain.Circunstancias_del_Delito.Circunstancias_del_Delito> ListaSelAll(Boolean ConRelaciones, string Where, string Order);
        Spartane.Core.Domain.Circunstancias_del_Delito.Circunstancias_del_DelitoPagingModel ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order);
        int ListaSelAllCount(string Where);
        IList<Spartane.Core.Domain.Circunstancias_del_Delito.Circunstancias_del_Delito> ListaSelAll(Boolean ConRelaciones, string Where);
    }
}
