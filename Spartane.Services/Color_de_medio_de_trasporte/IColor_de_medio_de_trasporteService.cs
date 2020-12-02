using System;
using Spartane.Core.Domain.Color_de_medio_de_trasporte;
using System.Collections.Generic;
using Spartane.Core.Domain.Data;

namespace Spartane.Services.Color_de_medio_de_trasporte
{
    /// <summary>
    /// Authentificated Service
    /// </summary>
    public partial interface IColor_de_medio_de_trasporteService
    {
        Int32 SelCount();
        IList<Spartane.Core.Domain.Color_de_medio_de_trasporte.Color_de_medio_de_trasporte> SelAll(Boolean ConRelaciones);
        IList<Spartane.Core.Domain.Color_de_medio_de_trasporte.Color_de_medio_de_trasporte> SelAllComplete(Boolean ConRelaciones);
        IList<Spartane.Core.Domain.Color_de_medio_de_trasporte.Color_de_medio_de_trasporte> SelAll(Boolean ConRelaciones, Int32 CurrentRecordInt32, Int32 RecordsDisplayedInt32);
        Spartane.Core.Domain.Color_de_medio_de_trasporte.Color_de_medio_de_trasporte GetByKey(short Key, Boolean ConRelaciones);
        bool Delete(short Key, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        Int16 Insert(Spartane.Core.Domain.Color_de_medio_de_trasporte.Color_de_medio_de_trasporte entity, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        Int16 Update(Spartane.Core.Domain.Color_de_medio_de_trasporte.Color_de_medio_de_trasporte entity, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        IList<Spartane.Core.Domain.Color_de_medio_de_trasporte.Color_de_medio_de_trasporte> SelAll(Boolean ConRelaciones, string Where, string Order);
        IList<Spartane.Core.Domain.Color_de_medio_de_trasporte.Color_de_medio_de_trasporte> ListaSelAll(Boolean ConRelaciones, string Where, string Order);
        Spartane.Core.Domain.Color_de_medio_de_trasporte.Color_de_medio_de_trasportePagingModel ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order);
        int ListaSelAllCount(string Where);
        IList<Spartane.Core.Domain.Color_de_medio_de_trasporte.Color_de_medio_de_trasporte> ListaSelAll(Boolean ConRelaciones, string Where);
    }
}
