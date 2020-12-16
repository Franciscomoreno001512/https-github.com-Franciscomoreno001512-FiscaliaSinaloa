using System;
using Spartane.Core.Domain.Modo_de_Asegurado_de_Drogas;
using System.Collections.Generic;
using Spartane.Core.Domain.Data;

namespace Spartane.Services.Modo_de_Asegurado_de_Drogas
{
    /// <summary>
    /// Authentificated Service
    /// </summary>
    public partial interface IModo_de_Asegurado_de_DrogasService
    {
        Int32 SelCount();
        IList<Spartane.Core.Domain.Modo_de_Asegurado_de_Drogas.Modo_de_Asegurado_de_Drogas> SelAll(Boolean ConRelaciones);
        IList<Spartane.Core.Domain.Modo_de_Asegurado_de_Drogas.Modo_de_Asegurado_de_Drogas> SelAllComplete(Boolean ConRelaciones);
        IList<Spartane.Core.Domain.Modo_de_Asegurado_de_Drogas.Modo_de_Asegurado_de_Drogas> SelAll(Boolean ConRelaciones, Int32 CurrentRecordInt32, Int32 RecordsDisplayedInt32);
        Spartane.Core.Domain.Modo_de_Asegurado_de_Drogas.Modo_de_Asegurado_de_Drogas GetByKey(int Key, Boolean ConRelaciones);
        bool Delete(int Key, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        Int32 Insert(Spartane.Core.Domain.Modo_de_Asegurado_de_Drogas.Modo_de_Asegurado_de_Drogas entity, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        Int32 Update(Spartane.Core.Domain.Modo_de_Asegurado_de_Drogas.Modo_de_Asegurado_de_Drogas entity, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        IList<Spartane.Core.Domain.Modo_de_Asegurado_de_Drogas.Modo_de_Asegurado_de_Drogas> SelAll(Boolean ConRelaciones, string Where, string Order);
        IList<Spartane.Core.Domain.Modo_de_Asegurado_de_Drogas.Modo_de_Asegurado_de_Drogas> ListaSelAll(Boolean ConRelaciones, string Where, string Order);
        Spartane.Core.Domain.Modo_de_Asegurado_de_Drogas.Modo_de_Asegurado_de_DrogasPagingModel ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order);
        int ListaSelAllCount(string Where);
        IList<Spartane.Core.Domain.Modo_de_Asegurado_de_Drogas.Modo_de_Asegurado_de_Drogas> ListaSelAll(Boolean ConRelaciones, string Where);
    }
}
