using System;
using Spartane.Core.Domain.Delitos_Violencia_Genero;
using System.Collections.Generic;
using Spartane.Core.Domain.Data;

namespace Spartane.Services.Delitos_Violencia_Genero
{
    /// <summary>
    /// Authentificated Service
    /// </summary>
    public partial interface IDelitos_Violencia_GeneroService
    {
        Int32 SelCount();
        IList<Spartane.Core.Domain.Delitos_Violencia_Genero.Delitos_Violencia_Genero> SelAll(Boolean ConRelaciones);
        IList<Spartane.Core.Domain.Delitos_Violencia_Genero.Delitos_Violencia_Genero> SelAllComplete(Boolean ConRelaciones);
        IList<Spartane.Core.Domain.Delitos_Violencia_Genero.Delitos_Violencia_Genero> SelAll(Boolean ConRelaciones, Int32 CurrentRecordInt32, Int32 RecordsDisplayedInt32);
        Spartane.Core.Domain.Delitos_Violencia_Genero.Delitos_Violencia_Genero GetByKey(int Key, Boolean ConRelaciones);
        bool Delete(int Key, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        Int32 Insert(Spartane.Core.Domain.Delitos_Violencia_Genero.Delitos_Violencia_Genero entity, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        Int32 Update(Spartane.Core.Domain.Delitos_Violencia_Genero.Delitos_Violencia_Genero entity, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        IList<Spartane.Core.Domain.Delitos_Violencia_Genero.Delitos_Violencia_Genero> SelAll(Boolean ConRelaciones, string Where, string Order);
        IList<Spartane.Core.Domain.Delitos_Violencia_Genero.Delitos_Violencia_Genero> ListaSelAll(Boolean ConRelaciones, string Where, string Order);
        Spartane.Core.Domain.Delitos_Violencia_Genero.Delitos_Violencia_GeneroPagingModel ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order);
        int ListaSelAllCount(string Where);
        IList<Spartane.Core.Domain.Delitos_Violencia_Genero.Delitos_Violencia_Genero> ListaSelAll(Boolean ConRelaciones, string Where);
    }
}
