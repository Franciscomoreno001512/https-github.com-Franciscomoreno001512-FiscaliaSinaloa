using System;
using Spartane.Core.Domain.Encuesta1;
using System.Collections.Generic;
using Spartane.Core.Domain.Data;

namespace Spartane.Services.Encuesta1
{
    /// <summary>
    /// Authentificated Service
    /// </summary>
    public partial interface IEncuesta1Service
    {
        Int32 SelCount();
        IList<Spartane.Core.Domain.Encuesta1.Encuesta1> SelAll(Boolean ConRelaciones);
        IList<Spartane.Core.Domain.Encuesta1.Encuesta1> SelAllComplete(Boolean ConRelaciones);
        IList<Spartane.Core.Domain.Encuesta1.Encuesta1> SelAll(Boolean ConRelaciones, Int32 CurrentRecordInt32, Int32 RecordsDisplayedInt32);
        Spartane.Core.Domain.Encuesta1.Encuesta1 GetByKey(int Key, Boolean ConRelaciones);
        bool Delete(int Key, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        Int32 Insert(Spartane.Core.Domain.Encuesta1.Encuesta1 entity, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        Int32 Update(Spartane.Core.Domain.Encuesta1.Encuesta1 entity, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        IList<Spartane.Core.Domain.Encuesta1.Encuesta1> SelAll(Boolean ConRelaciones, string Where, string Order);
        IList<Spartane.Core.Domain.Encuesta1.Encuesta1> ListaSelAll(Boolean ConRelaciones, string Where, string Order);
        Spartane.Core.Domain.Encuesta1.Encuesta1PagingModel ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order);
        int ListaSelAllCount(string Where);
        IList<Spartane.Core.Domain.Encuesta1.Encuesta1> ListaSelAll(Boolean ConRelaciones, string Where);
    }
}
