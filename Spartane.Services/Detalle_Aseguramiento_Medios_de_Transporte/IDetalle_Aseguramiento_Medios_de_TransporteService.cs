using System;
using Spartane.Core.Domain.Detalle_Aseguramiento_Medios_de_Transporte;
using System.Collections.Generic;
using Spartane.Core.Domain.Data;

namespace Spartane.Services.Detalle_Aseguramiento_Medios_de_Transporte
{
    /// <summary>
    /// Authentificated Service
    /// </summary>
    public partial interface IDetalle_Aseguramiento_Medios_de_TransporteService
    {
        Int32 SelCount();
        IList<Spartane.Core.Domain.Detalle_Aseguramiento_Medios_de_Transporte.Detalle_Aseguramiento_Medios_de_Transporte> SelAll(Boolean ConRelaciones);
        IList<Spartane.Core.Domain.Detalle_Aseguramiento_Medios_de_Transporte.Detalle_Aseguramiento_Medios_de_Transporte> SelAllComplete(Boolean ConRelaciones);
        IList<Spartane.Core.Domain.Detalle_Aseguramiento_Medios_de_Transporte.Detalle_Aseguramiento_Medios_de_Transporte> SelAll(Boolean ConRelaciones, Int32 CurrentRecordInt32, Int32 RecordsDisplayedInt32);
        Spartane.Core.Domain.Detalle_Aseguramiento_Medios_de_Transporte.Detalle_Aseguramiento_Medios_de_Transporte GetByKey(int Key, Boolean ConRelaciones);
        bool Delete(int Key, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        Int32 Insert(Spartane.Core.Domain.Detalle_Aseguramiento_Medios_de_Transporte.Detalle_Aseguramiento_Medios_de_Transporte entity, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        Int32 Update(Spartane.Core.Domain.Detalle_Aseguramiento_Medios_de_Transporte.Detalle_Aseguramiento_Medios_de_Transporte entity, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        IList<Spartane.Core.Domain.Detalle_Aseguramiento_Medios_de_Transporte.Detalle_Aseguramiento_Medios_de_Transporte> SelAll(Boolean ConRelaciones, string Where, string Order);
        IList<Spartane.Core.Domain.Detalle_Aseguramiento_Medios_de_Transporte.Detalle_Aseguramiento_Medios_de_Transporte> ListaSelAll(Boolean ConRelaciones, string Where, string Order);
        Spartane.Core.Domain.Detalle_Aseguramiento_Medios_de_Transporte.Detalle_Aseguramiento_Medios_de_TransportePagingModel ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order);
        int ListaSelAllCount(string Where);
        IList<Spartane.Core.Domain.Detalle_Aseguramiento_Medios_de_Transporte.Detalle_Aseguramiento_Medios_de_Transporte> ListaSelAll(Boolean ConRelaciones, string Where);
    }
}
