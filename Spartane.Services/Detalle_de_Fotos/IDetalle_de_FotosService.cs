using System;
using Spartane.Core.Domain.Detalle_de_Fotos;
using System.Collections.Generic;
using Spartane.Core.Domain.Data;

namespace Spartane.Services.Detalle_de_Fotos
{
    /// <summary>
    /// Authentificated Service
    /// </summary>
    public partial interface IDetalle_de_FotosService
    {
        Int32 SelCount();
        IList<Spartane.Core.Domain.Detalle_de_Fotos.Detalle_de_Fotos> SelAll(Boolean ConRelaciones);
        IList<Spartane.Core.Domain.Detalle_de_Fotos.Detalle_de_Fotos> SelAllComplete(Boolean ConRelaciones);
        IList<Spartane.Core.Domain.Detalle_de_Fotos.Detalle_de_Fotos> SelAll(Boolean ConRelaciones, Int32 CurrentRecordInt32, Int32 RecordsDisplayedInt32);
        Spartane.Core.Domain.Detalle_de_Fotos.Detalle_de_Fotos GetByKey(int Key, Boolean ConRelaciones);
        bool Delete(int Key, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        Int32 Insert(Spartane.Core.Domain.Detalle_de_Fotos.Detalle_de_Fotos entity, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        Int32 Update(Spartane.Core.Domain.Detalle_de_Fotos.Detalle_de_Fotos entity, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        IList<Spartane.Core.Domain.Detalle_de_Fotos.Detalle_de_Fotos> SelAll(Boolean ConRelaciones, string Where, string Order);
        IList<Spartane.Core.Domain.Detalle_de_Fotos.Detalle_de_Fotos> ListaSelAll(Boolean ConRelaciones, string Where, string Order);
        Spartane.Core.Domain.Detalle_de_Fotos.Detalle_de_FotosPagingModel ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order);
        int ListaSelAllCount(string Where);
        IList<Spartane.Core.Domain.Detalle_de_Fotos.Detalle_de_Fotos> ListaSelAll(Boolean ConRelaciones, string Where);
    }
}
