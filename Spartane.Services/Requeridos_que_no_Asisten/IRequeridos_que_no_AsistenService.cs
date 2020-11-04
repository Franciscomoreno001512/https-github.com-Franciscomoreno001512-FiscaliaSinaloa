using System;
using Spartane.Core.Domain.Requeridos_que_no_Asisten;
using System.Collections.Generic;
using Spartane.Core.Domain.Data;

namespace Spartane.Services.Requeridos_que_no_Asisten
{
    /// <summary>
    /// Authentificated Service
    /// </summary>
    public partial interface IRequeridos_que_no_AsistenService
    {
        Int32 SelCount();
        IList<Spartane.Core.Domain.Requeridos_que_no_Asisten.Requeridos_que_no_Asisten> SelAll(Boolean ConRelaciones);
        IList<Spartane.Core.Domain.Requeridos_que_no_Asisten.Requeridos_que_no_Asisten> SelAllComplete(Boolean ConRelaciones);
        IList<Spartane.Core.Domain.Requeridos_que_no_Asisten.Requeridos_que_no_Asisten> SelAll(Boolean ConRelaciones, Int32 CurrentRecordInt32, Int32 RecordsDisplayedInt32);
        Spartane.Core.Domain.Requeridos_que_no_Asisten.Requeridos_que_no_Asisten GetByKey(int Key, Boolean ConRelaciones);
        bool Delete(int Key, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        Int32 Insert(Spartane.Core.Domain.Requeridos_que_no_Asisten.Requeridos_que_no_Asisten entity, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        Int32 Update(Spartane.Core.Domain.Requeridos_que_no_Asisten.Requeridos_que_no_Asisten entity, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        IList<Spartane.Core.Domain.Requeridos_que_no_Asisten.Requeridos_que_no_Asisten> SelAll(Boolean ConRelaciones, string Where, string Order);
        IList<Spartane.Core.Domain.Requeridos_que_no_Asisten.Requeridos_que_no_Asisten> ListaSelAll(Boolean ConRelaciones, string Where, string Order);
        Spartane.Core.Domain.Requeridos_que_no_Asisten.Requeridos_que_no_AsistenPagingModel ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order);
        int ListaSelAllCount(string Where);
        IList<Spartane.Core.Domain.Requeridos_que_no_Asisten.Requeridos_que_no_Asisten> ListaSelAll(Boolean ConRelaciones, string Where);
    }
}
