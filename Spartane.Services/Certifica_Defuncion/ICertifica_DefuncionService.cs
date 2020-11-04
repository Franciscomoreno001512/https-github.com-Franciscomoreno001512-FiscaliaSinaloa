using System;
using Spartane.Core.Domain.Certifica_Defuncion;
using System.Collections.Generic;
using Spartane.Core.Domain.Data;

namespace Spartane.Services.Certifica_Defuncion
{
    /// <summary>
    /// Authentificated Service
    /// </summary>
    public partial interface ICertifica_DefuncionService
    {
        Int32 SelCount();
        IList<Spartane.Core.Domain.Certifica_Defuncion.Certifica_Defuncion> SelAll(Boolean ConRelaciones);
        IList<Spartane.Core.Domain.Certifica_Defuncion.Certifica_Defuncion> SelAllComplete(Boolean ConRelaciones);
        IList<Spartane.Core.Domain.Certifica_Defuncion.Certifica_Defuncion> SelAll(Boolean ConRelaciones, Int32 CurrentRecordInt32, Int32 RecordsDisplayedInt32);
        Spartane.Core.Domain.Certifica_Defuncion.Certifica_Defuncion GetByKey(short Key, Boolean ConRelaciones);
        bool Delete(short Key, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        Int16 Insert(Spartane.Core.Domain.Certifica_Defuncion.Certifica_Defuncion entity, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        Int16 Update(Spartane.Core.Domain.Certifica_Defuncion.Certifica_Defuncion entity, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        IList<Spartane.Core.Domain.Certifica_Defuncion.Certifica_Defuncion> SelAll(Boolean ConRelaciones, string Where, string Order);
        IList<Spartane.Core.Domain.Certifica_Defuncion.Certifica_Defuncion> ListaSelAll(Boolean ConRelaciones, string Where, string Order);
        Spartane.Core.Domain.Certifica_Defuncion.Certifica_DefuncionPagingModel ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order);
        int ListaSelAllCount(string Where);
        IList<Spartane.Core.Domain.Certifica_Defuncion.Certifica_Defuncion> ListaSelAll(Boolean ConRelaciones, string Where);
    }
}
