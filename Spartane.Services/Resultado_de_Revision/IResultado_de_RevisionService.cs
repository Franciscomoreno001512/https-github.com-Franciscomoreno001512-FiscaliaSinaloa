using System;
using Spartane.Core.Domain.Resultado_de_Revision;
using System.Collections.Generic;
using Spartane.Core.Domain.Data;

namespace Spartane.Services.Resultado_de_Revision
{
    /// <summary>
    /// Authentificated Service
    /// </summary>
    public partial interface IResultado_de_RevisionService
    {
        Int32 SelCount();
        IList<Spartane.Core.Domain.Resultado_de_Revision.Resultado_de_Revision> SelAll(Boolean ConRelaciones);
        IList<Spartane.Core.Domain.Resultado_de_Revision.Resultado_de_Revision> SelAllComplete(Boolean ConRelaciones);
        IList<Spartane.Core.Domain.Resultado_de_Revision.Resultado_de_Revision> SelAll(Boolean ConRelaciones, Int32 CurrentRecordInt32, Int32 RecordsDisplayedInt32);
        Spartane.Core.Domain.Resultado_de_Revision.Resultado_de_Revision GetByKey(short Key, Boolean ConRelaciones);
        bool Delete(short Key, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        Int16 Insert(Spartane.Core.Domain.Resultado_de_Revision.Resultado_de_Revision entity, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        Int16 Update(Spartane.Core.Domain.Resultado_de_Revision.Resultado_de_Revision entity, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        IList<Spartane.Core.Domain.Resultado_de_Revision.Resultado_de_Revision> SelAll(Boolean ConRelaciones, string Where, string Order);
        IList<Spartane.Core.Domain.Resultado_de_Revision.Resultado_de_Revision> ListaSelAll(Boolean ConRelaciones, string Where, string Order);
        Spartane.Core.Domain.Resultado_de_Revision.Resultado_de_RevisionPagingModel ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order);
        int ListaSelAllCount(string Where);
        IList<Spartane.Core.Domain.Resultado_de_Revision.Resultado_de_Revision> ListaSelAll(Boolean ConRelaciones, string Where);
    }
}
