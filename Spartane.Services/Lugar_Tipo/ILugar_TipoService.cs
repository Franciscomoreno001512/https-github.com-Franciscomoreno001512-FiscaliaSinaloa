using System;
using Spartane.Core.Domain.Lugar_Tipo;
using System.Collections.Generic;
using Spartane.Core.Domain.Data;

namespace Spartane.Services.Lugar_Tipo
{
    /// <summary>
    /// Authentificated Service
    /// </summary>
    public partial interface ILugar_TipoService
    {
        Int32 SelCount();
        IList<Spartane.Core.Domain.Lugar_Tipo.Lugar_Tipo> SelAll(Boolean ConRelaciones);
        IList<Spartane.Core.Domain.Lugar_Tipo.Lugar_Tipo> SelAllComplete(Boolean ConRelaciones);
        IList<Spartane.Core.Domain.Lugar_Tipo.Lugar_Tipo> SelAll(Boolean ConRelaciones, Int32 CurrentRecordInt32, Int32 RecordsDisplayedInt32);
        Spartane.Core.Domain.Lugar_Tipo.Lugar_Tipo GetByKey(int Key, Boolean ConRelaciones);
        bool Delete(int Key, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        Int32 Insert(Spartane.Core.Domain.Lugar_Tipo.Lugar_Tipo entity, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        Int32 Update(Spartane.Core.Domain.Lugar_Tipo.Lugar_Tipo entity, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        IList<Spartane.Core.Domain.Lugar_Tipo.Lugar_Tipo> SelAll(Boolean ConRelaciones, string Where, string Order);
        IList<Spartane.Core.Domain.Lugar_Tipo.Lugar_Tipo> ListaSelAll(Boolean ConRelaciones, string Where, string Order);
        Spartane.Core.Domain.Lugar_Tipo.Lugar_TipoPagingModel ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order);
        int ListaSelAllCount(string Where);
        IList<Spartane.Core.Domain.Lugar_Tipo.Lugar_Tipo> ListaSelAll(Boolean ConRelaciones, string Where);
    }
}
