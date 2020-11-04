using System;
using Spartane.Core.Domain.Color_Piel;
using System.Collections.Generic;
using Spartane.Core.Domain.Data;

namespace Spartane.Services.Color_Piel
{
    /// <summary>
    /// Authentificated Service
    /// </summary>
    public partial interface IColor_PielService
    {
        Int32 SelCount();
        IList<Spartane.Core.Domain.Color_Piel.Color_Piel> SelAll(Boolean ConRelaciones);
        IList<Spartane.Core.Domain.Color_Piel.Color_Piel> SelAllComplete(Boolean ConRelaciones);
        IList<Spartane.Core.Domain.Color_Piel.Color_Piel> SelAll(Boolean ConRelaciones, Int32 CurrentRecordInt32, Int32 RecordsDisplayedInt32);
        Spartane.Core.Domain.Color_Piel.Color_Piel GetByKey(int Key, Boolean ConRelaciones);
        bool Delete(int Key, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        Int32 Insert(Spartane.Core.Domain.Color_Piel.Color_Piel entity, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        Int32 Update(Spartane.Core.Domain.Color_Piel.Color_Piel entity, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        IList<Spartane.Core.Domain.Color_Piel.Color_Piel> SelAll(Boolean ConRelaciones, string Where, string Order);
        IList<Spartane.Core.Domain.Color_Piel.Color_Piel> ListaSelAll(Boolean ConRelaciones, string Where, string Order);
        Spartane.Core.Domain.Color_Piel.Color_PielPagingModel ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order);
        int ListaSelAllCount(string Where);
        IList<Spartane.Core.Domain.Color_Piel.Color_Piel> ListaSelAll(Boolean ConRelaciones, string Where);
    }
}
